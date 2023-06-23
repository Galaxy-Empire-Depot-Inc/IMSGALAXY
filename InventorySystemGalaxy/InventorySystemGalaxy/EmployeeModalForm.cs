
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystemGalaxy
{
    public partial class EmployeeModalForm : Form
    {
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

            //bgPanel.BackColor = Color.FromArgb(59, 116, 192);

        }

        private void EmployeeModalForm_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestore = FirestoreDb.Create("imsgalaxy-f7419");

            positionComboBox.SelectedIndex = 0;
            passwordTextbox.Text = "@GalaxyEmpire";
            statusComboBox.SelectedIndex = 1;

            employeePB.AllowDrop = true;


        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextbox.Text = idNumberTextBox.Text;

        }

        private void positionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            departmentTextBox.Text = positionComboBox.GetItemText(positionComboBox.SelectedItem + " Department");
        }

        async void addEmployee()
        {
            /*image = employeePictureBox.Image;
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
            MessageBox.Show("Added Successfully");*/

            String IDCODE = idNumberTextBox.Text.Trim();

            if (firstNameTextBox.Text != "" || lastNameTextBox.Text != "" || contactNoTextBox.Text != "" || usernameTextbox.Text != "")
            {
                image = employeePB.Image;
                //Generate unique FileName.jpg
                string fileName = $"{Guid.NewGuid()}.jpg";

                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageData = memoryStream.ToArray();

                    // Upload the image to Cloud Storage
                    storageClient.UploadObject(bucketName, fileName, "image/jpeg", new MemoryStream(imageData));
                }

                imageUrl = $"https://storage.googleapis.com/{bucketName}/{fileName}";
                DocumentReference documentReference = firestore.Collection("Employees").Document(IDCODE);
                DocumentSnapshot snapshot = await documentReference.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    MessageBox.Show("ID CODE ALREADY EXIST");
                }
                else
                {

                    Dictionary<string, object> Employeedictionary = new Dictionary<string, object>()
                {
                    { "FirstName",firstNameTextBox.Text },
                    { "MiddleName", middleNameTextBox.Text},
                    { "LastName", lastNameTextBox.Text},
                    { "ContactNo", contactNoTextBox.Text },
                    { "IdNumber", idNumberTextBox.Text },
                    { "Status",statusComboBox.SelectedItem},
                    { "Position",positionComboBox.SelectedItem },
                    { "Department",departmentTextBox.Text },
                    { "Username",usernameTextbox.Text },
                    { "Password",passwordTextbox.Text },
                    { "imageUrl",imageUrl }
                };
                    if (MessageBox.Show("Do you want to Add this Employee?", "Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        documentReference.SetAsync(Employeedictionary);
                        MessageBox.Show("ADDED SUCCESSFULLY");
                        ClearForm();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            contactNoTextBox.Text = "";
            idNumberTextBox.Text = "";
            departmentTextBox.Text = "";
            usernameTextbox.Text = "";
            passwordTextbox.Text = "";
            positionComboBox.SelectedIndex = 0;
            employeePB.Image = Properties.Resources.icons8_image_100;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployee();
        }

        /*private void getImageFromGallery()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                employeePB.Image = new Bitmap(open.FileName);
                img = open.FileName;
            }
        }*/

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            //getImageFromGallery();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.JPG;*.PNG;*.bmp;)|*.JPG;*PNG;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                employeePB.Image = new Bitmap(open.FileName);
            }
        }

        private void imagePictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    employeePB.Image = Image.FromFile(fileNames[0]);
            }
        }

        private void imagePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contactNoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (contactNoTextBox.Text.Length > 11)
            {
                // Truncate the text to 11 characters
                contactNoTextBox.Text = contactNoTextBox.Text.Substring(0, 11);
                contactNoTextBox.SelectionStart = 11; // Set the cursor position to the end
            }
        }

        private void contactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignore the key press event
                e.Handled = true;

            }
        }
    }


}