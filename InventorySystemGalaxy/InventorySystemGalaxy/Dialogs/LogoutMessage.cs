using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGalaxy.Dialogs
{
    public partial class LogoutMessage : Form
    {
        public LogoutMessage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            homeScreenForm.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
