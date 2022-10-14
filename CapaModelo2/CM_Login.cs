using System;
using System.Data;
using System.Data.SqlClient; //SQL
using MySql.Data.MySqlClient;

namespace CapaModelo2
{
    public class CM_Login
    {
        public static bool corre;
        public static string user;
        public static string contra;
        public static int eye;
        public static int inte = 3;
        public static string tipo;

        public static string nombr;
        public static string ci;
        public static string email;
        public static string tele;
        public static string databa = "lcastro";
        public static string cone = "server=localhost;uid=lcastro;" +"pwd=54269024;database=lcastro;";

        public static string Cserver = "localhost";
        public static string Cdatabase = "lcastro";
        public static string Cuser = "lcastro";
        public static string Cpass = "54269024";
        public static string Cadena;

        public static MySqlConnection conex;
      
        public MySqlConnection getConexion()
        {
            if (CM_Login.cone == null)
            {
                MySqlConnection con2 = new MySqlConnection(CM_Login.Cadena);
                con2.Open();
            }
            return CM_Login.conex;
        }
    }

}
