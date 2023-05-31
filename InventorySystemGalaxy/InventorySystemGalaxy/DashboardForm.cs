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
<<<<<<< HEAD

           // LoadProductCounts();
            

           /* LoadProductCounts();*/


=======

>>>>>>> 2a7d7ab1dcc210f83795b885c096ecd9bec17bcc
        }


<<<<<<< HEAD

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

            conn.Close();*/

            conn.Close();

=======
>>>>>>> 2a7d7ab1dcc210f83795b885c096ecd9bec17bcc
        }

 
}
