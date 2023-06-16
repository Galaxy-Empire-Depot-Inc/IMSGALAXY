
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
using Google.Apis.Auth.OAuth2;

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
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
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
            saveImage();
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

    }


}