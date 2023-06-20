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
        Thread thread;
        public LogoutMessage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Hide();
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void openForm(object obj)
        {
            Application.Run(new LoginForm());
            
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
