using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGalaxy
{
    public partial class EmployeeHomeScreenForm : Form
    {
        FirestoreDb db;
        public EmployeeHomeScreenForm()
        {
            InitializeComponent();
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.ShowModal.Enabled = false;
        }

        private void EmployeeHomeScreenForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
            LoadUserName();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not admin to Enter this Page!");
        }

        public void loadForm(Object form)
        {
            if (mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form form1 = form as Form;
            form1.TopLevel = false;
            form1.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form1);
            this.mainPanel.Tag = form1;
            form1.Show();
            {

            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            loadForm(new WarehouseForm());
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            /*LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();*/
        }
        async void LoadUserName()
        {
            DocumentReference documentReference = db.Collection("Employees").Document(LoginForm.username);
            DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
            string username = documentSnapshot.GetValue<string>("Username");
            string imageUrl = documentSnapshot.GetValue<string>("imageUrl");
            lbl_GreetUser.Text = "Hi, " + username;
            var storageClient = StorageClient.Create();

            // Get the filename from the image URL
            string fileName = Path.GetFileName(imageUrl);

            // Download the image from Cloud Storage
            var downloadStream = new MemoryStream();
            storageClient.DownloadObject("imsgalaxy-f7419.appspot.com", fileName, downloadStream);
            downloadStream.Position = 0;

            // Create an Image object from the downloaded image data
            Image downloadedImage = Image.FromStream(downloadStream);

            // Display the image in the PictureBox
            showImagesPictureBox.Image = downloadedImage;
            lbl_GreetUser.Text = "Hi, " + username;
            loadForm(new DashboardForm());

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            ChangePasswordModal changePassword = new ChangePasswordModal();
            changePassword.ShowDialog();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Warning_Message warningMessageDialog = new Warning_Message();
            warningMessageDialog.ShowDialog();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
