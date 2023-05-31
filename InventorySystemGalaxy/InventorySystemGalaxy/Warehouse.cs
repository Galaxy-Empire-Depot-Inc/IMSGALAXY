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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void BTN_AddModal_Click(object sender, EventArgs e)
        {
            WarehouseModalForm modalForm = new WarehouseModalForm();
            modalForm.ShowDialog();
        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
