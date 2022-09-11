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
namespace CapaDatos2
{
    public class CD_Login
    {
        SqlConnection con2 = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Ke_Fruta; Integrated Security=True");

        public int conSQL(string usuario, string contrasena)
        {
                int conn;    
                con2.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombres,Tipo_usuario,CI,Email,Telefono FROM usuarios WHERE Usuario = @usuario AND Password = @pas ", con2);

                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataReader dr = cmd.ExecuteReader();

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


