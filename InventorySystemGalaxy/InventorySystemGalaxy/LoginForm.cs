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
>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e
using InventorySystemGalaxy.Classes;
using Google.Cloud.Firestore.V1;


namespace InventorySystemGalaxy
{
    public partial class LoginForm : Form
    {
<<<<<<< HEAD

        FirestoreDb db;

        public static string username, userpass;
=======

        FirestoreDb db;
        public static string username;

            /*FirestoreDb db = FirestoreDb.Create("imsgalaxy - f7419");*/



        /*FirestoreDb db;*/



        // MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");

        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12619718; UID=sql12619718; PASSWORD=FzBpKXqUFl");
        public static String getUserName;

        //MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");


        FirestoreDb firestoreDb;

>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e

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
            //Application.Exit();
            Warning_Message warning_Message = new Warning_Message();
            warning_Message.ShowDialog();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        async void LoginData()
        {
<<<<<<< HEAD
            
                username = UserTxtBox.Text;

                userpass = PassTxtBox.Text;


            DocumentReference documentReference = db.Collection("Admin_User").Document(username);
            DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
=======


            string username = UserTxtBox.Text;
            string password = PassTxtBox.Text;

            /*DocumentReference documentReference = db.Collection("Admin_User").Document(username);
            DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                AdminData adminData = documentSnapshot.ConvertTo<AdminData>();
                if (username == adminData.Username && password == adminData.Password)
                {
                    WelcomeMessageForm welcomeMessageForm = new WelcomeMessageForm();
                    this.Hide();
                    welcomeMessageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INCORRECT");
                }

                 if (UserTxtBox.Text == "")
                 {
                     MessageBox.Show("INPUT USERNAME");
                 }
                 else if (PassTxtBox.Text == "")
                 {
                     MessageBox.Show("INPUT Password");
                 }


            }
            else
            {
                MessageBox.Show("NOT FOUND!");
            }*/


            DocumentReference documentReference = db.Collection("Admin_User").Document(username);
            DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e

            AdminData adminData = documentReference.GetSnapshotAsync().Result.ConvertTo<AdminData>();

            if (adminData != null)
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
<<<<<<< HEAD
=======
            }

            /*if (documentSnapshot.Exists)
            {
                AdminData adminData = documentSnapshot.ConvertTo<AdminData>();
                MessageBox.Show("LOGIN");
>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e
            }

<<<<<<< HEAD
=======

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



>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e
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
=======

>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e
        async void GetData()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            DocumentReference documentReference=db.Collection("Admin_User").Document(UserTxtBox.Text);
            DocumentSnapshot snapshot=await documentReference.GetSnapshotAsync();

            if(snapshot.Exists)
            {
                Dictionary<string, object> admin = snapshot.ToDictionary(); 

            }
        }
<<<<<<< HEAD
=======

>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e
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
<<<<<<< HEAD
=======

>>>>>>> 8784edfd2206e9d7841a1ec3d73dc5c03e2b065e
    }
}
