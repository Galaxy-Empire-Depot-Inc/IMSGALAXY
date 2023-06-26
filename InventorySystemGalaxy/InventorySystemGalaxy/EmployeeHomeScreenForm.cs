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
    public partial class EmployeeHomeScreenForm : Form
    {
        public EmployeeHomeScreenForm()
        {
            InitializeComponent();
        }

        private void EmployeeHomeScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not admin to Enter this Page!");
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

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            loadForm(new WarehouseForm());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
