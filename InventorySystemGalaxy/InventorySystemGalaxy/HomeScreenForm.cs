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
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        public void loadForm(Object form)
        {
            if (mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form form1 = form as Form;
            form1.TopLevel = false;
            form1.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form1);
            this.mainPanel.Tag = form1;
            form1.Show();
            {

            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
        }
        private void customButton2_Click(object sender, EventArgs e)
        {

        }
        private void customButton3_Click(object sender, EventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Enter(object sender, EventArgs e)
        {
            customButton1.BackColor = Color.FromArgb(74, 173, 255);
            customButton1.ForeColor = Color.Black;

        }

        private void customButton1_Leave(object sender, EventArgs e)
        {
            customButton1.BackColor = Color.FromArgb(59, 116, 192);
            customButton1.ForeColor = Color.White;

        }

        private void customButton2_Enter(object sender, EventArgs e)
        {
            customButton2.BackColor = Color.FromArgb(74, 173, 255);
            customButton2.ForeColor = Color.Black;
        }

        private void customButton2_Leave(object sender, EventArgs e)
        {
            customButton2.BackColor = Color.FromArgb(59, 116, 192);
            customButton2.ForeColor = Color.White;
        }

        private void customButton3_Enter(object sender, EventArgs e)
        {
            customButton3.BackColor = Color.FromArgb(74, 173, 255);
            customButton3.ForeColor = Color.Black;
        }

        private void customButton3_Leave(object sender, EventArgs e)
        {
            customButton3.BackColor = Color.FromArgb(59, 116, 192);
            customButton3.ForeColor = Color.White;
        }

        private void customButton4_Enter(object sender, EventArgs e)
        {
            customButton4.BackColor = Color.FromArgb(74, 173, 255);
            customButton4.ForeColor = Color.Black;
        }

        private void customButton4_Leave(object sender, EventArgs e)
        {
            customButton4.BackColor = Color.FromArgb(59, 116, 192);
            customButton4.ForeColor = Color.White;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {

            Warning_Message warningMessageDialog = new Warning_Message();
            warningMessageDialog.ShowDialog();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
