using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace InventorySystemGalaxy
{
    public class LoadTableData
    {
        public LoadTableData(MySqlConnection sqlConnection, MySqlCommand sqlCommand, MySqlDataAdapter sqlDataAdapter, DataTable dataTable, DataGridView dataGridView, String query) 
        {
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }

    }
}
