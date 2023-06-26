﻿using System;
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
        FirestoreDb db;

        public static string username, userpass;

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

            username = UserTxtBox.Text;
            userpass = PassTxtBox.Text;


            

            if (UserTxtBox.Text == "Admin")
            {
                DocumentReference documentReference = db.Collection("Admin_User").Document(username);
                DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
                if (documentSnapshot.Exists)
                {
                    AdminData adminData = documentSnapshot.ConvertTo<AdminData>();
                    if (username == adminData.Username && userpass == adminData.Password)
                    {
                        WelcomeMessageForm welcomeMessageForm = new WelcomeMessageForm();
                        this.Hide();
                        welcomeMessageForm.ShowDialog();
                       /* if (welcomeMessageForm.ShowDialog() == DialogResult.OK)
                        {
                            HomeScreenForm homeScreenForm = new HomeScreenForm();
                            this.Hide();
                            homeScreenForm.ShowDialog();
                        }*/
                        
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
                }
            }
            else
            {
                DocumentReference documentReference = db.Collection("Employees").Document(username);
                DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
                if (documentSnapshot.Exists)
                {
                    EmployeeData employeeData = documentSnapshot.ConvertTo<EmployeeData>();
                    if (username == employeeData.Username && userpass == employeeData.Password)
                    {
                        WelcomeMessageForm welcomeMessageForm = new WelcomeMessageForm();
                        this.Hide();
                        welcomeMessageForm.ShowDialog();
                        /*if (welcomeMessageForm.ShowDialog() == DialogResult.OK)
                        {
                            EmployeeHomeScreenForm employeeHomeScreenForm = new EmployeeHomeScreenForm();
                            this.Hide();
                            employeeHomeScreenForm.ShowDialog();
                        }*/
                       

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
                }
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

        async void GetData()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            DocumentReference documentReference = db.Collection("Admin_User").Document(UserTxtBox.Text);
            DocumentSnapshot snapshot = await documentReference.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> admin = snapshot.ToDictionary();

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
