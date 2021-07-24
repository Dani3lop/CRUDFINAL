using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControllerConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection ValorRetorno = Conexion.GetConnect();
            return ValorRetorno;
        }
    }
}
