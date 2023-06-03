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

<<<<<<< HEAD
       // MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");
=======
<<<<<<< HEAD
        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12619718; UID=sql12619718; PASSWORD=FzBpKXqUFl");
        public static String getUserName;
=======
        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");
>>>>>>> dc3502728d3742ed5d119e66b29bd8274b0552c0


>>>>>>> 9f8b4407e6595af3b51886765d86c538b49dad1f
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

            try
            {

                /*if (UserTxtBox.Text == "")
                {
                    MessageBox.Show("INPUT USERNAME");
                }
                else if (PassTxtBox.Text == "")
                {
                    MessageBox.Show("INPUT Password");
                }
                else
                {

                    getUserName = UserTxtBox.Text;

                    String username, password;
                    username = UserTxtBox.Text;
                    password = PassTxtBox.Text;
                    string query = "SELECT * FROM admin_table WHERE admin_user = '" + UserTxtBox.Text + "' AND admin_pass = '" + PassTxtBox.Text + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        username = UserTxtBox.Text;
                        password = PassTxtBox.Text;

                        // MessageBox.Show("LOGIN CORRECT");

                        WelcomeMessageForm messageBoxDialog = new WelcomeMessageForm();
                        messageBoxDialog.ShowDialog();
                        this.Close();
                        ClearTxtBoxes();

                    }
                    else
                    {
                        MessageBox.Show("INCORRECT DETAILS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearTxtBoxes();

                    }

                }*/


                /*string path = AppDomain.CurrentDomain.BaseDirectory + @"imsgalaxy-f7419-firebase-adminsdk-eusnr-02750ac5ad.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

                FirestoreDb db = FirestoreDb.Create("imsgalaxy - f7419");

                MessageBox.Show("Successfully Bitch");*/

                string username = UserTxtBox.Text;
                string userpass = PassTxtBox.Text;


                DocumentReference documentReference = db.Collection("Admin_User").Document(username);
                AdminData adminData = documentReference.GetSnapshotAsync().Result.ConvertTo<AdminData>();

                if (adminData != null)
                {

                    if (userpass == adminData.pass)
                    {
                        MessageBox.Show("LOGIN");
                    }
                    else
                    {
                        MessageBox.Show("FAILED TO LOGIN");
                    }

                }
                else
                {
                    MessageBox.Show("No data found");
                }


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
    }
}
