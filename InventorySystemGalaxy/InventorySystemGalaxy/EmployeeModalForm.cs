
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

namespace InventorySystemGalaxy
{
    public partial class EmployeeModalForm : Form
    {
        Thread thread;
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
            string path = AppDomain.CurrentDomain.BaseDirectory + @"imsgalaxy-f7419-firebase-adminsdk-eusnr-02750ac5ad.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            FirestoreDb db= FirestoreDb.Create("imsgalaxy - f7419");

            MessageBox.Show("Successfully Bitch");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployee();
        }

    }
}