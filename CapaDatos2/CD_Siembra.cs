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
    public class CD_Siembra
    {

        public static void Norma()
        {
            if (CM_Siembra.Nitra < 2)
            {
                CM_Siembra.NitroDosis = 25;
                if (CM_Siembra.NitroDis >= CM_Siembra.NitroDosis)
                {
                    CM_Siembra.Ntotal = CM_Siembra.Ntotal + CM_Siembra.NitroDosis;
                    RestN();
                }
                else { MessageBox.Show("Nitrogeno insuficiente"); }
            }
        }

        public static void Fos()
        {
            CM_Siembra.EQ = 10;
            CM_Siembra.Nc = 14;
            if (CM_Siembra.Ps < CM_Siembra.Nc)
            {
                CM_Siembra.FosfoDosis = (CM_Siembra.Nc - CM_Siembra.Ps) * CM_Siembra.EQ;
                if (CM_Siembra.FosfoDis >= CM_Siembra.FosfoDosis)
                {
                    CM_Siembra.Ptotal = CM_Siembra.Ptotal + CM_Siembra.FosfoDosis;
                    RestF();
                }
                else { MessageBox.Show("Fosforo insuficiente"); }
            }
        }

        public static void Maco()
        {
            CM_Siembra.EQ = 5;
            CM_Siembra.Nc = 14;
            if (CM_Siembra.Ns < CM_Siembra.Nc)
            {
                CM_Siembra.NitroDosis = (CM_Siembra.Nc - CM_Siembra.Ns) * CM_Siembra.EQ;
                if (CM_Siembra.NitroDis >= CM_Siembra.NitroDosis)
                {
                    CM_Siembra.Ntotal = CM_Siembra.Ntotal + CM_Siembra.NitroDosis;
                    RestN();
                }
                else { MessageBox.Show("Nitrogeno insuficiente"); }
            }
        }

        public static void Enca()
        {
            CM_Siembra.EQ = 45;
            CM_Siembra.NcD = 4.2;

            if (CM_Siembra.Np < CM_Siembra.NcD)
            {
                CM_Siembra.NitroDosis = (int)(CM_Siembra.EQ * (CM_Siembra.NcD - CM_Siembra.Np));
                if (CM_Siembra.NitroDis >= CM_Siembra.NitroDosis)
                {
                    CM_Siembra.Ntotal = CM_Siembra.Ntotal + CM_Siembra.NitroDosis;
                    RestN();
                }
                else { MessageBox.Show("Nitrogeno insuficiente"); }
            }
        }

        public static void Fertilizacion()
        {
            if (CM_Siembra.fer == 1)
            {
                switch (CM_Siembra.Etapa)
                {
                    case 0:
                        CD_Siembra.vaciar();
                        break;
                    case 1:
                        Fos();

                        Norma();

                        break;
                    case 2:
                        Maco();

                        break;
                    case 3:
                        Enca();

                        break;
                    default:
                        CM_Siembra.NitroDosis = 0;
                        CM_Siembra.FosfoDosis = 0;
                        break;
                }
            }
        }

        public static void RestN()
        {
            if (CM_Siembra.NitroDosis > 0)
            {
                reducirN();
            }
        }

        public static void RestF()
        {
            if (CM_Siembra.FosfoDosis > 0)
            {
                reducirF();
            }
        }



        public static void reducirN()
        {
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE INV SET Cantidad = Cantidad - " + CM_Siembra.NitroDosis + " where Nombre = 'Nitrogeno' AND comprador = '" + CM_Login.user + "';", con2);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Nitrogeno Reducido");
            }
            else
            {
                MessageBox.Show("ERROR Contacta a un administrador");
            }
            con2.Close();
        }

        public static void reducirF()
        {
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE INV SET Cantidad = Cantidad - " + CM_Siembra.FosfoDosis + " where Nombre = 'Fosforo' AND comprador = '" + CM_Login.user + "';", con2);
            int b = cmd.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Fosforo Reducido");
            }
            else
            {
                MessageBox.Show("ERROR Contacta a un administrador");
            }
            con2.Close();
        }


        public static void vaciar()
        {
            CM_Siembra.NitroDosis = 0; //Nitrogeno agregado en fase
            CM_Siembra.FosfoDosis = 0; //Fosforo agregado en fase


            CM_Siembra.Nc = 0; //Nivel critico
            CM_Siembra.Ps = 0; //Fosforo en suelo
            CM_Siembra.EQ = 0; //Equivalente en fertilizante 
            CM_Siembra.Ns = 0; //Nitrogeno en suelo
            CM_Siembra.Np = 0; //Nitrogeno en planta
            CM_Siembra.NcD = 0; //Nivel critico Double
            CM_Siembra.Ntotal = 0; //Nitrogeno total agregado
            CM_Siembra.Ptotal = 0; //Fosforo total agregado
        }



        public static void siembra()
        {

            MySqlConnection con = new MySqlConnection(CM_Login.cone);
            con.Open();

            MySqlCommand query1 = new MySqlCommand("SELECT * from Siembra where Sector='" + CM_Siembra.Sector + "' AND Propietario='" + CM_Login.user + "';", con);
            MySqlDataAdapter da = new MySqlDataAdapter(query1);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            CM_Siembra.r = ds1.Tables[0].Rows.Count;


            if (CM_Siembra.r > 0)
            {
                siembra2();

            }
            else
            {
                siembra1();
            }
            con.Close();


        }



        public static void siembra1()
        {
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();
            MySqlCommand query2 = new MySqlCommand("insert into Siembra(Sector,Propietario,Estado) values('" + CM_Siembra.Sector + "','" + CM_Login.user + "','Disponible');", con2);
            int r = query2.ExecuteNonQuery();
            if (r > 0)
            {

            }
            else
            {

            }
            con2.Close();


        }

        public static void siembra2()
        {
            MySqlConnection con3 = new MySqlConnection(CM_Login.cone);
            con3.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT Plantacion,Estado,Fase,Inicio,Fin FROM Siembra where Sector = '" + CM_Siembra.Sector + "' AND Propietario ='" + CM_Login.user + "'", con3);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())

            {
                CM_Siembra.Plantacion = dr["Plantacion"].ToString();
                CM_Siembra.Estado = dr["Estado"].ToString();
                CM_Siembra.Fase = dr["Fase"].ToString();
                CM_Siembra.Inicio = dr["Inicio"].ToString();
                CM_Siembra.Fin = dr["Fin"].ToString();
            }
            con3.Close();
        }



        public static void Plantar()
        {
            switch (CM_Siembra.ss)
            {
                case "Trigo":
                    CM_Siembra.fer = 1;
                    CM_Siembra.Plantacion = "Trigo";
                    trigo();
                    break;
                case "Cebada":
                    CM_Siembra.fer = 1;
                    CM_Siembra.Plantacion = "Cebada";
                    Cebada();
                    break;
                case "Limon":
                    CM_Siembra.fer = 0;
                    CM_Siembra.Plantacion = "Limon";
                    Arbol();
                    break;
                case "Manzana":
                    CM_Siembra.fer = 0;
                    CM_Siembra.Plantacion = "Manzana";
                    Arbol();
                    break;
                default:


                    break;
            }
        }

        public static void trigo()
        {
            DateTime thisDay = DateTime.Today;
            MySqlConnection contri = new MySqlConnection(CM_Login.cone);
            contri.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE siembra SET Plantacion ='Trigo', Estado='En proceso', Inicio = curdate(), Fin= curdate() + INTERVAL 6 MONTH where Sector = '" + CM_Siembra.Sector + "' AND Propietario = '" + CM_Login.user + "';", contri);
            int b = cmd.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Trigo Plantado");
            }
            else
            {
                MessageBox.Show("ERROR Contacta a un administrador");
            }
            contri.Close();
        }

        public static void Cebada()
        {
            DateTime thisDay = DateTime.Today;
            MySqlConnection cebad = new MySqlConnection(CM_Login.cone);
            cebad.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE siembra SET Plantacion ='Cebada', Estado='En proceso', Inicio = curdate(), Fin= curdate() + INTERVAL 150 DAY where Sector = '" + CM_Siembra.Sector + "' AND Propietario = '" + CM_Login.user + "';", cebad);
            int b = cmd.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Cebada Plantada");
            }
            else
            {
                MessageBox.Show("ERROR Contacta a un administrador");
            }
            cebad.Close();
        }

        public static void Arbol()
        {
            DateTime thisDay = DateTime.Today;
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE siembra SET Plantacion ='" + CM_Siembra.ss + "', Estado='En proceso', Inicio = curdate(), Fin= curdate() + INTERVAL 3 YEAR where Sector = '" + CM_Siembra.Sector + "' AND Propietario = '" + CM_Login.user + "';", con2);
            int b = cmd.ExecuteNonQuery();
            if (b > 0)
            {
                MessageBox.Show("Arbol Plantado");
            }
            else
            {
                MessageBox.Show("ERROR Contacta a un administrador");
            }
            con2.Close();
        }

        public static void tiempos()
        {
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT Inicio,Fin FROM Siembra where Sector = '" + CM_Siembra.Sector + "' AND Propietario ='" + CM_Login.user + "'", con2);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())

            {
                CM_Siembra.Inicio = dr["Inicio"].ToString();
                CM_Siembra.Fin = dr["Fin"].ToString();

                var parsedDate = DateTime.Parse(CM_Siembra.Fin);



            }
            con2.Close();
        }

        public static void fin() //FIN DE CULTIVO
        {
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT Sector,Fin FROM Siembra where Propietario ='" + CM_Login.user + "'", con2);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())

            {
                CM_Siembra.secl = dr["Sector"].ToString();
                CM_Siembra.Fin = dr["Fin"].ToString();


                if (CM_Siembra.Fin == DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt")) //Si la fecha del fin del cultivo es igual a la de hoy
                {
                    CM_Siembra.Estado = "Listo para cosechar";
                    MySqlCommand query = new MySqlCommand("UPDATE siembra SET Estado='Listo para cosechar' where Sector = '" + CM_Siembra.secl + "' AND Propietario = '" + CM_Login.user + "';", con2);
                    int b = query.ExecuteNonQuery();
                    if (b > 0)
                    {
                        MessageBox.Show("El sector: " + CM_Siembra.secl + " esta listo para cosechar"); //Notifica que sector esta preparado para ser cosechado

                    }
                    else
                    {
                        MessageBox.Show("ERROR Contacta a un administrador");
                    }
                }

            }
        }

        public static void rotacion() //Rotacion
        {
            MySqlConnection con2 = new MySqlConnection(CM_Login.cone);
            con2.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT Sector FROM Siembra where Propietario ='" + CM_Login.user + "' AND Estado=Listo para cosechar", con2);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())

            {
                CM_Siembra.secl = dr["Sector"].ToString();
                MySqlCommand query = new MySqlCommand("UPDATE siembra SET Plantacion ='" + CM_Siembra.Plantacion + "', Estado='En descanso', Inicio = curdate()+ INTERVAL 6 MONTH where Sector = '" + CM_Siembra.Sector + "' AND Propietario = '" + CM_Login.user + "';", con2);
                    int b = query.ExecuteNonQuery();
                    if (b > 0)
                    {
                    MessageBox.Show("El sector: " + CM_Siembra.secl + " fue cosechado");

                    switch (CM_Siembra.Plantacion)
                    {
                        case "Trigo":
                            MySqlCommand trigo = new MySqlCommand("UPDATE siembra SET Plantacion ='Cebada', Estado='En descanso', Fin= curdate() + INTERVAL 12 MONTH where Sector = '" + CM_Siembra.Sector + "' AND Propietario = '" + CM_Login.user + "';", con2);
                            int tri = trigo.ExecuteNonQuery();
                            break;
                        case "Cebada":
                            MySqlCommand ceba = new MySqlCommand("UPDATE siembra SET Plantacion ='Trigo', Estado='En descanso', Fin= curdate() + INTERVAL 3 YEAR where Sector = '" + CM_Siembra.Sector + "' AND Propietario = '" + CM_Login.user + "';", con2);
                            int ceb = ceba.ExecuteNonQuery();
                            break;
                        case "Limon":
                            MySqlCommand limo = new MySqlCommand("UPDATE siembra SET Plantacion ='Trigo', Estado='En descanso', Fin= curdate() + INTERVAL 3 YEAR where Sector = '" + CM_Siembra.Sector + "' AND Propietario = '" + CM_Login.user + "';", con2);
                            int lim = limo.ExecuteNonQuery();
                            break;
                        case "Manzana":
                            
                            
                            break;
                        default:


                            break;
                    }

                }
                    else
                    {
                        MessageBox.Show("ERROR Contacta a un administrador");
                    }
            }
        }

        
        }

    }



