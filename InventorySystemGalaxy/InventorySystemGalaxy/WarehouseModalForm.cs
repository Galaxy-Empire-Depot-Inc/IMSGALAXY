using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGalaxy
{
    public partial class WarehouseModalForm : Form
    {
        public WarehouseModalForm()
        {
            InitializeComponent();
            warehouseComboBox.SelectedIndex = 0;

        }

        private void sortTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                refTextBox.Focus();
            }
        }

        private void refTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                descriptionTextBox.Focus();
            }

        }

        private void descriptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemCodeTextBox.Focus();
            }
        }

        private void itemCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                colorTextBox.Focus();
            }
        }

        private void colorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                avTextbox.Focus();
            }
        }

        private void avTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wattsTextBox.Focus();
            }
        }

        private void wattsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctnLTextBox.Focus();
            }
        }

        private void ctnLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctnHTextBox.Focus();
            }
        }

        private void ctnHTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctnWTextBox.Focus();
            }
        }

        private void ctnWTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sizeTextBox.Focus();
            }
        }

        private void sizeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxTextBox.Focus();
            }
        }

        private void boxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                srpTextBox.Focus();
            }
        }

        private void srpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                warehouseComboBox.Focus();
            }
        }

        private void warehouseComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBtn.Focus();
            }
        }

        private void srpTextBox_TextChanged(object sender, EventArgs e)
        {
            double srp;
            double dp;
            string srpText = srpTextBox.Text;
            srp = double.Parse(srpText);
            dp = (double)(srp * .50);
            dpTextBox.Text = dp.ToString();

        }
    }
}
