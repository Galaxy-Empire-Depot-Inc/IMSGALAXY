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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventorySystemGalaxy
{
    public partial class HomeScreenForm : Form
    {

        FirestoreDb db;

        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
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

        private void customButton1_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }
        private void customButton2_Click(object sender, EventArgs e)
        {
            loadForm(new EmployeeForm());
        }
        private void customButton3_Click(object sender, EventArgs e)
        {
            loadForm(new WarehouseForm());
        }

        private void customButton4_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Enter(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb(74, 173, 255);
            dashboardBtn.ForeColor = Color.Black;

        }

        private void customButton1_Leave(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb(59, 116, 192);
            dashboardBtn.ForeColor = Color.White;

        }

        private void customButton2_Enter(object sender, EventArgs e)
        {
            employeeBtn.BackColor = Color.FromArgb(74, 173, 255);
            employeeBtn.ForeColor = Color.Black;
        }

        private void customButton2_Leave(object sender, EventArgs e)
        {
            employeeBtn.BackColor = Color.FromArgb(59, 116, 192);
            employeeBtn.ForeColor = Color.White;
        }

        private void customButton3_Enter(object sender, EventArgs e)
        {
            warehouseBtn.BackColor = Color.FromArgb(74, 173, 255);
            warehouseBtn.ForeColor = Color.Black;
        }

        private void customButton3_Leave(object sender, EventArgs e)
        {
            warehouseBtn.BackColor = Color.FromArgb(59, 116, 192);
            warehouseBtn.ForeColor = Color.White;
        }

        private void customButton4_Enter(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Color.FromArgb(74, 173, 255);
            logoutBtn.ForeColor = Color.Black;
        }

        private void customButton4_Leave(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Color.FromArgb(59, 116, 192);
            logoutBtn.ForeColor = Color.White;
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

        async void LoadUserName()
        {
            DocumentReference documentReference = db.Collection("Admin_User").Document(LoginForm.username);
            DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
            string username = documentSnapshot.GetValue<string>("Username");
            lbl_GreetUser.Text = "Hi, " + username;

        }

        private async void HomeScreenForm_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");

            LoadUserName();
            loadForm(new DashboardForm());

            


        }
    }
}
