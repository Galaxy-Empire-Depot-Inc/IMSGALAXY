﻿using MySql.Data.MySqlClient;
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




            /*LoadProductCounts();
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> c620bb97c183ef918167973141644f65d0a9f0ad

>>>>>>> 237cdd8127faa25b149fc488e5db276b425f8d92
            String getProductsQuery = "SELECT item_code, description, picture, category FROM product_table";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getProductsQuery);*/


            /*LoadProductCounts();
            String getProductsQuery = "SELECT item_code, description, picture, category FROM product_table";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getProductsQuery);*/



<<<<<<< HEAD
=======
           // LoadProductCounts();
            

           /* LoadProductCounts();*/




<<<<<<< HEAD
=======
 
=======
>>>>>>> 2a7d7ab1dcc210f83795b885c096ecd9bec17bcc
>>>>>>> 9f8b4407e6595af3b51886765d86c538b49dad1f
>>>>>>> dc3502728d3742ed5d119e66b29bd8274b0552c0
>>>>>>> c620bb97c183ef918167973141644f65d0a9f0ad
>>>>>>> 237cdd8127faa25b149fc488e5db276b425f8d92
        }
    }
 
}

