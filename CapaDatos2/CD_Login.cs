using CapaModelo2;
using System.Data.SqlClient; //SQL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaDatos2

{
    public class CD_Login
    {

        


        public int conSQL(string usuario, string contrasena)
        {
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();
            int conn;    
                
                MySqlCommand cmd = new MySqlCommand("SELECT Nombres,Tipo_usuario,CI,Email,Telefono FROM Usuarios WHERE Usuario = @usuario AND Password = @pas ", con2);

                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);



                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                 MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    CM_Login.nombr = dr["Nombres"].ToString();
                    CM_Login.email = dr["Email"].ToString();
                    CM_Login.ci = dr["CI"].ToString();
                    CM_Login.tele = dr["Telefono"].ToString();
                }
            
            if (dt.Rows.Count == 1)
            {
                conn = 1;
            }else{
                conn = 0;
            }

            con2.Close();
            return conn;

            }
          }
    }


