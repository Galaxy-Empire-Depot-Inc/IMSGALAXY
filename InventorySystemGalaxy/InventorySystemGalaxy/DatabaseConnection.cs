using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemGalaxy
{
    internal class DatabaseConnection
    {
        MySqlConnection conn = new MySqlConnection("SERVER=sql12.freesqldatabase.com; DATABASE=sql12619718; UID=sql12619718; PASSWORD=FzBpKXqUFl");
    }
}
