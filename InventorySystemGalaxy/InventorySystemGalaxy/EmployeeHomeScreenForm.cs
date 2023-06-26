using Google.Cloud.Firestore;
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
            lbl_GreetUser.Text = "Hi, " + username;
            loadForm(new DashboardForm());

        }


    }
}
