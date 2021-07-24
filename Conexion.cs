using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {
        public static MySqlConnection GetConnect()
        {
            MySqlConnection connect;
            string server = "127.0.0.1";
            string database = "dbasignacionesempleados";
            string user = "root";
            string password = "";

            try
            {
                connect = new MySqlConnection("server = " + server + "; database = " + database + "; uid = " + user + ";pwd = " + password);
                connect.Open();
                return connect;
            }
            catch (Exception)
            {

                return connect = null;
            }

            
        }
    }
}
