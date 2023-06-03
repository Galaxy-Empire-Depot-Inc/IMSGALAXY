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
        /*MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12622083; UID=sql12622083; PASSWORD=C4kTB5qYR6");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt;*/
        public DashboardForm()
        {
            InitializeComponent();
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD


=======
<<<<<<< HEAD
            LoadProductCounts();
            String getProductsQuery = "SELECT item_code, description, picture, category FROM product_table";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getProductsQuery);
>>>>>>> c3e1482551f4a0d71797342ac30f620d324ed28d

            /*LoadProductCounts();
            String getProductsQuery = "SELECT item_code, description, picture, category FROM product_table";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getProductsQuery);*/



           // LoadProductCounts();
            

           /* LoadProductCounts();*/



<<<<<<< HEAD
        }
        }

 
=======
>>>>>>> 2a7d7ab1dcc210f83795b885c096ecd9bec17bcc
>>>>>>> 9f8b4407e6595af3b51886765d86c538b49dad1f
>>>>>>> dc3502728d3742ed5d119e66b29bd8274b0552c0
        }
    }
>>>>>>> c3e1482551f4a0d71797342ac30f620d324ed28d
}
