using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PayParkingAdminCsharp
{
    internal class Database
    {
        public static string marcelaDbConnection = "server='172.16.176.20'; user='payparking'; database='e_parking'; password='payparking2022'";
        public MySqlConnection marcelaMySqlConnection = new MySqlConnection(marcelaDbConnection);

        public static string altaCittaDbConnection = "server='172.16.174.201'; user='payparking'; database='e_parking'; password='payparking2020'";
        public MySqlConnection altaCittaMySqlConnection = new MySqlConnection(altaCittaDbConnection);

        public bool marcelaDb() {
            try {
                marcelaMySqlConnection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool closeMarcelaDb()
        {
            try 
            {
                marcelaMySqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool altaCittaDb()
        {
            try
            {
                altaCittaMySqlConnection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool closeAltaCittaDb()
        {
            try
            {
                altaCittaMySqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
