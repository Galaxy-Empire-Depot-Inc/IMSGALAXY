
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Google.Protobuf.Collections;
using Google.Cloud.Storage.V1;

namespace InventorySystemGalaxy
{
    public partial class EmployeeModalForm : Form
    {
        Thread thread;
        FirestoreDb firestore;
        string imageUrl;
        string img;
        public EmployeeModalForm()
        {
            InitializeComponent();

            bgPanel.BackColor = Color.FromArgb(59, 116, 192);

        }

        private void EmployeeModalForm_Load(object sender, EventArgs e)
        {
            positionComboBox.SelectedIndex = 0;
            passwordTextbox.Text = "@GalaxyEmpire";
            statusComboBox.SelectedIndex = 1;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"imsgalaxy-f7419-firebase-adminsdk-eusnr-02750ac5ad.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestore = FirestoreDb.Create("imsgalaxy-f7419");
            imagePictureBox.AllowDrop = true;
            

        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextbox.Text = idNumberTextBox.Text;

        }

        private void positionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            departmentTextBox.Text = positionComboBox.GetItemText(positionComboBox.SelectedItem + " Department");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Hide();
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void openForm(object obj)
        {
            Application.Run(new EmployeeForm());
        }

        public void addEmployee()
        {
            CollectionReference collectionReference = firestore.Collection("Employee");
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                {"FirstName",firstNameTextBox.Text },
                {"MiddleName", middleNameTextBox.Text},
                {"LastName", lastNameTextBox.Text},
                {"ContactNo", contactNoTextBox.Text },
                {"IdNumber", idNumberTextBox.Text },
                {"Status",statusComboBox.SelectedItem},
                {"Position",positionComboBox.SelectedItem },
                {"Department",departmentTextBox.Text },
                {"Username",usernameTextbox.Text },
                {"Password",passwordTextbox.Text }
            };
            collectionReference.AddAsync(data1);
            MessageBox.Show("Added Successfully");

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployee();
        }

        private void getImageFromGallery()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = new Bitmap(open.FileName);
                img = open.FileName;
            }
        }

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            getImageFromGallery();
        }

        private void imagePictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    imagePictureBox.Image = Image.FromFile(fileNames[0]);
            }
        }

        private void imagePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void saveImage()
        {
           
        }

        private FirestoreDb CreateFirestoreClient()
        {
            string projectId = "imsgalaxy-f7419";
            string pathToServiceAccountKey = "imsgalaxy-f7419-firebase-adminsdk-eusnr-02750ac5ad";

            FirestoreDb db = FirestoreDb.Create(projectId, new FirestoreClientBuilder
            {
                CredentialsPath = pathToServiceAccountKey
            }.Build());

            return db;
        }

        private string UploadImageToStorage(string imagePath)
        {
            string projectId = "imsgalaxy-f7419";
            string bucketName = "gs://imsgalaxy-f7419.appspot.com";
            string objectName = img;

            var storage = StorageClient.Create();
            storage.UploadObject(bucketName, objectName, null, File.OpenRead(imagePath));

            imageUrl = $"https://firebasestorage.googleapis.com/v0/b/{bucketName}/o/{objectName}?alt=media";

            return imageUrl;
        }

        private async Task InsertImageIntoFirestore(string imageUrl)
        {
            FirestoreDb db = CreateFirestoreClient();

            // Assuming you have a collection named "images" and a document ID for the image
            DocumentReference docRef = db.Collection("images").Document("imageId");

            // Create a dictionary with the URL value
            Dictionary<string, object> imageData = new Dictionary<string, object>
    {
        { "imageUrl", imageUrl }
    };

            // Set the data in the Firestore document
            await docRef.SetAsync(imageData);
        }


    }


}