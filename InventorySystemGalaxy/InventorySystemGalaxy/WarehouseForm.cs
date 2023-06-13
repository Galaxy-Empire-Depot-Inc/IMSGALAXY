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
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void ShowModal_Click(object sender, EventArgs e)
        {
            WarehouseModalForm warehouseModalForm = new WarehouseModalForm();
            warehouseModalForm.ShowDialog();
            warehouseModalForm.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
