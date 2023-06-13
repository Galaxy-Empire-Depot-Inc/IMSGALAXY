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

namespace InventorySystemGalaxy
{
    public partial class LoginForm : Form
    {

        FirestoreDb db;


        // MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");

        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12619718; UID=sql12619718; PASSWORD=FzBpKXqUFl");
        public static String getUserName;

        //MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");

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

        async void LoginData()
        {

            try
            {

                string username = UserTxtBox.Text;
                string userpass = PassTxtBox.Text;

                DocumentReference documentReference = db.Collection("Admin_User").Document(username);
                //   DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();

                AdminData adminData = documentReference.GetSnapshotAsync().Result.ConvertTo<AdminData>();
                 
                if(adminData != null) 
                {

                    if (userpass == adminData.password)
                    {

                        WelcomeMessageForm welcomeMessageForm = new WelcomeMessageForm();
                        this.Hide();
                        welcomeMessageForm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("INCORRECT");
                    }

                }
                else
                {
                    MessageBox.Show("Not FOUND");
                }

                /*if (documentSnapshot.Exists)
                {
                    AdminData adminData = documentSnapshot.ConvertTo<AdminData>();
                    MessageBox.Show("LOGIN");
                }
                else
                {
                    MessageBox.Show("NOT LOGIN");
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
        }
    }
}
