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
    public partial class Warning_Message : Form
    {
        public Warning_Message()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelMessage_Click(object sender, EventArgs e)
        {

        }

        private void Warning_Message_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
