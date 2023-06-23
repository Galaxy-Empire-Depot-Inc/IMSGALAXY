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

        String warehouseName;
        WarehouseForm warehouseForm = new WarehouseForm();

        public WarehouseLabelSelection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void allRB_CheckedChanged(object sender, EventArgs e)
        {
            warehouseName = "All";
            warehouseForm.WarehouseLabel.Text = "Warehouse(All)";
        }

        private void grpRadio_Enter(object sender, EventArgs e)
        {
        }

        private void storeRB_CheckedChanged(object sender, EventArgs e)
        {
            warehouseName = "Store";
            warehouseForm.WarehouseLabel.Text = "Warehouse(Store)";
            this.Close();

        }

        private void tmsRB_CheckedChanged(object sender, EventArgs e)
        {
            warehouseName = "TMS";
            warehouseForm.WarehouseLabel.Text = "Warehouse(TMS)";

        }

        private void mlbRB_CheckedChanged(object sender, EventArgs e)
        {
            warehouseName = "MLB";
            warehouseForm.WarehouseLabel.Text = "Warehouse(MLB)";

        }
    }
}
