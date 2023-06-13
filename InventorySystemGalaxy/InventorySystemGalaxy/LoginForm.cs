using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Google.Cloud.Firestore;
using InventorySystemGalaxy.Classes;
using Google.Cloud.Firestore.V1;

namespace InventorySystemGalaxy
{
    public partial class LoginForm : Form
    {
        FirestoreDb firestoreDb;
        public LoginForm()
        {

            InitializeComponent();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void customButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call the button click event handler
                loginBtn_Click(sender, e);
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginData();

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        public void LoginData()
        {

            string username = UserTxtBox.Text.Trim();
            string password = PassTxtBox.Text;

            DocumentReference docRef = firestoreDb.Collection("Admin_User").Document(username);
            AdminData data = docRef.GetSnapshotAsync().Result.ConvertTo<AdminData>();


            if (data != null)
            {
                if (password == data.Password)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Tang ina Mo");
            }


        }

        private void ClearTxtBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }

        private void PassTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginData();
            }
        }

        private void UserTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginData();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"imsgalaxy-f7419-firebase-adminsdk-eusnr-02750ac5ad.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestoreDb = FirestoreDb.Create("imsgalaxy-f7419");
        }
    }
}
