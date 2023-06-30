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
    public partial class ChangePasswordModal : Form
    {

        FirestoreDb db;
        string bucketName = "imsgalaxy-f7419.appspot.com";
        Dictionary<string, object> dict;
        DocumentReference documentReference;
        public ChangePasswordModal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePasswordModal_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
        }

        private void UpdatePassword()
        {
            LoginForm loginForm = new LoginForm();
            if (passwordTextBox.Text == confirmPasswordTextBox.Text)
            {
                documentReference = db.Collection("Employees").Document(LoginForm.username);
                dict = new Dictionary<string, object>()
                {
                    {"Password",passwordTextBox.Text }
                };

                if (MessageBox.Show("Do you want to Update your password?", "Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    documentReference.UpdateAsync(dict);
                    MessageBox.Show("UPDATED SUCCESSFULLY");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Password is not Match");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePassword();
        }
    }
}
