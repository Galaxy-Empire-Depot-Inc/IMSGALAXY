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
    public partial class WarehouseLabelSelection : Form
    {

        public WarehouseLabelSelection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SelectWarehouseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.WarehouseLabel.Text = "HOTDOG";

        }
    }
}
