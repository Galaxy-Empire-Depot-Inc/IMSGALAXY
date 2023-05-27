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
        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12619718; UID=sql12619718; PASSWORD=FzBpKXqUFl");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt;
        public DashboardForm()
        {
            InitializeComponent();
        }


        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadProductCounts();
            
        }

        private void LoadProductCounts()
        {
            String CountProduct = "SELECT COUNT(*) AS NumberOFProducts FROM product_table";
            String CountAvailability = "SELECT COUNT(*) AS NumberOFProducts FROM product_table WHERE availability = 1";
            String CountDisplay = "SELECT COUNT(*) AS NumberOFProducts FROM product_table WHERE display = 1";
            String CountDamage = "SELECT COUNT(*) AS NumberOFProducts FROM product_table WHERE repair = 1";
            

            conn.Open();
            command = new MySqlCommand(CountProduct, conn);


            MySqlDataReader reader1 = command.ExecuteReader();

            while (reader1.Read())
            {
                lbl_TotalP.Text = reader1.GetString(0);
            }

            conn.Close();

            conn.Open();
            command = new MySqlCommand(CountAvailability, conn);


            MySqlDataReader reader2 = command.ExecuteReader();

            while (reader2.Read())
            {
                lbl_AvailableP.Text = reader2.GetString(0);
            }

            conn.Close();

            conn.Open();
            command = new MySqlCommand(CountDisplay, conn);


            MySqlDataReader reader3 = command.ExecuteReader();

            while (reader3.Read())
            {
                lbl_DisplayP.Text = reader3.GetString(0);
            }

            conn.Close();

            conn.Open();
            command = new MySqlCommand(CountDamage, conn);


            MySqlDataReader reader4 = command.ExecuteReader();

            while (reader4.Read())
            {
                lbl_DamageP.Text = reader4.GetString(0);
            }

            conn.Close();
        }

        private void btn_TotalP_Click(object sender, EventArgs e)
        {
            String getProductsQuery = "SELECT item_code, description, picture, category FROM product_table";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getProductsQuery);
        }

        private void btn_AvailableP_Click(object sender, EventArgs e)
        {
            String getAvailbleQuery = "SELECT item_code, description, picture, category FROM product_table WHERE availability = 1";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getAvailbleQuery);
        }

        private void btn_DisplayP_Click(object sender, EventArgs e)
        {
            String getDisplayQuery = "SELECT item_code, description, picture, category FROM product_table WHERE display = 1";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getDisplayQuery);
        }

        private void btn_DamageP_Click(object sender, EventArgs e)
        {
            String getDamageQuery = "SELECT item_code, description, picture, category FROM product_table WHERE repair = 1";
            LoadTableData loadTable = new LoadTableData(conn, command, adapter, dt, producttable, getDamageQuery);
        }
    }
}
