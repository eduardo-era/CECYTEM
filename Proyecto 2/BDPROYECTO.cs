using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace Proyecto_2
{
    public class BDPROYECTO
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=horarios; Uid=root; pwd=307277891;");
            conectar.Open();
            return conectar;
        }

    }
}
