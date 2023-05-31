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

namespace InventorySystemGalaxy
{
    public partial class LoginForm : Form
    {

        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");


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
    }
}
