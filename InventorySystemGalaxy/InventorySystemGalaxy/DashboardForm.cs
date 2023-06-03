using MySql.Data.MySqlClient;
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
    public partial class DashboardForm : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt;
        public DashboardForm()
        {
            InitializeComponent();
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {


        }
    }
}
