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
    public partial class EmployeeForm : Form
    {
        /*MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12619718; UID=sql12619718; PASSWORD=FzBpKXqUFl");*/
        public EmployeeForm()
        {
            InitializeComponent();
            /*refreshData();*/
        }

        /*public void refreshData()
        {
            string refreshData = "SELECT * FROM employee_table";
            MySqlDataAdapter adapter = new MySqlDataAdapter(refreshData, conn);
            DataSet dataSet = new System.Data.DataSet();
            adapter.Fill(dataSet, "employee_table");
            employeeTable.DataSource = dataSet.Tables[0];

        }*/

        private void customButton1_Click(object sender, EventArgs e)
        {
            EmployeeModalForm employeeModalForm = new EmployeeModalForm();
            employeeModalForm.ShowDialog();
            this.Hide();
        }
    }
}
