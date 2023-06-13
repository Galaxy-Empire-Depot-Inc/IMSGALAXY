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
<<<<<<< HEAD
=======
using InventorySystemGalaxy.Classes;
using Google.Cloud.Firestore.V1;
>>>>>>> c7113623bb0a2168a1c31d0a973d1d1f6494e8d8

namespace InventorySystemGalaxy
{
    public partial class LoginForm : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        

            FirestoreDb db = FirestoreDb.Create("imsgalaxy - f7419");
=======
<<<<<<< HEAD
=======

>>>>>>> d4d70dc644b50c8e08abc8ced41cce6d27cdd5c0

        FirestoreDb db;
>>>>>>> c7113623bb0a2168a1c31d0a973d1d1f6494e8d8


        // MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");

        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12619718; UID=sql12619718; PASSWORD=FzBpKXqUFl");
        public static String getUserName;

        //MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");


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

        async void LoginData()
        {
<<<<<<< HEAD
            /* try
             {
=======
>>>>>>> c7113623bb0a2168a1c31d0a973d1d1f6494e8d8

            string username = UserTxtBox.Text.Trim();
            string password = PassTxtBox.Text;

<<<<<<< HEAD
<<<<<<< HEAD
                 if (UserTxtBox.Text == "")
                 {
                     MessageBox.Show("INPUT USERNAME");
                 }
                 else if (PassTxtBox.Text == "")
                 {
                     MessageBox.Show("INPUT Password");
                 }
                 else
                 {
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

                 }




             }
             catch (MySqlException ex)
             {
                 MessageBox.Show("Not Connected");
             }*/

            
=======
<<<<<<< HEAD
                string username = UserTxtBox.Text;
=======

               // string username = UserTxtBox.Text;
>>>>>>> d4d70dc644b50c8e08abc8ced41cce6d27cdd5c0
                string userpass = PassTxtBox.Text;

                DocumentReference documentReference = db.Collection("Admin_User").Document(username);
                //   DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();

                AdminData adminData = documentReference.GetSnapshotAsync().Result.ConvertTo<AdminData>();
                 
                if(adminData != null) 
                {

                    if (userpass == adminData.Password)
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


            /*DocumentReference docRef = firestoreDb.Collection("Admin_User").Document(username);
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
            }*/


>>>>>>> c7113623bb0a2168a1c31d0a973d1d1f6494e8d8
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

<<<<<<< HEAD
        async void GetData()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"imsgalaxy-f7419-firebase-adminsdk-eusnr-02750ac5ad.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            DocumentReference documentReference=db.Collection("Admin_User").Document(UserTxtBox.Text);
            DocumentSnapshot snapshot=await documentReference.GetSnapshotAsync();

            if(snapshot.Exists)
            {
                Dictionary<string, object> admin = snapshot.ToDictionary(); 

            }
        }
=======
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

            /*string path = AppDomain.CurrentDomain.BaseDirectory + @"imsgalaxy-f7419-firebase-adminsdk-eusnr-02750ac5ad.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestoreDb = FirestoreDb.Create("imsgalaxy-f7419");*/
        }
>>>>>>> c7113623bb0a2168a1c31d0a973d1d1f6494e8d8
    }
}
