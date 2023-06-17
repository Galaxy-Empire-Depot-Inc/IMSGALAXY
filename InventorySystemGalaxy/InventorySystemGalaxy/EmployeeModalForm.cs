
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
using Google.Cloud.Storage.V1;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace InventorySystemGalaxy
{
    public partial class EmployeeModalForm : Form
    {
        Thread thread;
        FirestoreDb firestore;
        string imageUrl;
        string img;
        StorageClient storageClient = StorageClient.Create();
        Image image;
        string id;
        string bucketName = "imsgalaxy-f7419.appspot.com";
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
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestore = FirestoreDb.Create("imsgalaxy-f7419");
            employeePictureBox.AllowDrop = true;


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
            image = employeePictureBox.Image;
            //Generate unique FileName.jpg
            string fileName = $"{Guid.NewGuid()}.jpg";

            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageData = memoryStream.ToArray();

                // Upload the image to Cloud Storage
                storageClient.UploadObject(bucketName, fileName, "image/jpeg", new MemoryStream(imageData));
            }

            //get the link of the image in cloudstorage
            imageUrl = $"https://storage.googleapis.com/{bucketName}/{fileName}";
            id = idNumberTextBox.Text;
            DocumentReference documentReference = firestore.Collection("Employee").Document(id);
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
                {"Password",passwordTextbox.Text },
                {"imageUrl",imageUrl }
            };
            documentReference.SetAsync(data1);
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
                employeePictureBox.Image = new Bitmap(open.FileName);
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
                    employeePictureBox.Image = Image.FromFile(fileNames[0]);
            }
        }

        private void imagePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


    }


}