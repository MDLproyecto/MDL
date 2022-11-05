using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //SQL
using MySql.Data.MySqlClient; //MYSQL
using CapaModelo2;
using Microsoft.VisualBasic;
using WindowsFormsApp2.Compras;
using System.Runtime.InteropServices;//DLLs para mover el form

namespace WindowsFormsApp2
{
    public partial class CCompras : Form
    {
        //Esto es para que se pueda mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        MySqlConnection con = new MySqlConnection(CM_Login.cone);
        int can;
        string tipoPre;
        int pr = 1;
        int IoS = 0;
 
        public CCompras()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txbCan.Text == "")
            {
                MessageBox.Show("Tienes que ingresar alguna cantidad!");
            }
            else { 
            DialogResult dr = MessageBox.Show("Estas seguro?",
                      "Confirmacion", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                     
                    can = Convert.ToInt32(txbCan.Text);
                    con.Open();
                    
                    MySqlCommand query1 = new MySqlCommand("select ("+tipoPre+ ") from Insumos where Insumo='"+ cbPro.Text+"';", con);
                    pr = (int)query1.ExecuteScalar();
                    int prf = pr * can;

                    MySqlCommand queryIoS = new MySqlCommand("select IoS from Insumos where Insumo= '"+ cbPro.Text +"';", con);
                    object result = queryIoS.ExecuteScalar();
                    result = (result == DBNull.Value) ? null : result;
                    int IoS = Convert.ToInt32(result);
    

                    MySqlCommand query2= new MySqlCommand("insert into Compras(Nombre,Cantidad,Precio,Precio_Final,Fecha_Actual,Hora_Actual,Comprador,Tipo_de_Pago,Notas,IoS) values('" + cbPro.Text+"', '"+can+"', '"+pr+"', '"+prf+"', '"+lblDate.Text+ "', '"+lblClock.Text+"', '"+CM_Login.user+"', '"+cbPa.Text+"', '"+txbNotas.Text+ "', '"+IoS +"');", con);
                    int r = query2.ExecuteNonQuery();
                 MySqlCommand query3 = new MySqlCommand("insert into Historial(Nombre,Cantidad,Precio,Precio_Final,Fecha_Actual,Hora_Actual,Comprador,Tipo_de_Pago,Notas,IoS) values('" + cbPro.Text +"','"+can+"', '"+pr + "', '" + prf + "', '" + lblDate.Text + "', '" + lblClock.Text + "', '" + CM_Login.user + "', '" + cbPa.Text + "', '" + txbNotas.Text + "', '" + IoS + "');", con);
                        int rr = query3.ExecuteNonQuery();
                        if (rr > 0)
                        {
                            MessageBox.Show("Historial Actualizado");
                        }
                        else
                        {
                            MessageBox.Show("ERROR Contacta a un administrador");
                        }

                        if (IoS == 0)
                        {
                            MySqlCommand query = new MySqlCommand("SELECT * from inv where Nombre='"+cbPro.Text+"' AND Comprador='"+CM_Login.user +"';",con);
                            MySqlDataAdapter da = new MySqlDataAdapter(query);
                            DataSet ds1 = new DataSet();
                            da.Fill(ds1);
                            int b = ds1.Tables[0].Rows.Count;


                            if (b > 0)
                            {
                                MySqlCommand cmd = new MySqlCommand("UPDATE INV SET Cantidad = Cantidad + " + can + " where Nombre = '"+cbPro.Text+"' AND comprador = '" + CM_Login.user + "';", con);
                                int c = cmd.ExecuteNonQuery();
                                if (c > 0)
                                {
                                    
                                }
                                else
                                {
                                   
                                }
                            }
                            else
                            {
                               
                                MySqlCommand query4 = new MySqlCommand("insert into inv(Nombre,Cantidad,Comprador) values('" + cbPro.Text + "','" + can + "','" + CM_Login.user + "');", con);
                                int a = query4.ExecuteNonQuery();
                                if (a > 0)
                                {

                                }
                                else
                                {

                                }
                            }

                            
                        }


                        if (r > 0)
                    {
                        MessageBox.Show("Datos Guardados");
                    }
                    else
                    {
                        MessageBox.Show("ERROR Contacta a un administrador");
                    }
                    con.Close();
                    break;
                case DialogResult.No:
                    break;
            }
            }
        }


       

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            //Fecha y hora
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // esconde el formulario 2
            this.Hide();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

            if (CM_Login.tipo == "admin")
            {
                this.admin.Start();
            }
            else
            {
                this.otro.Start();
            }

            this.actualizar.Start();
            Fecha.Start();
            try
            {
                con.Open();
                
                    MySqlCommand sc = new MySqlCommand("select (Insumo) from Insumos", con);
                    MySqlDataReader reader;
                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Insumo", typeof(string));
                    dt.Load(reader);
                    cbPro.ValueMember = "Insumo";
                    cbPro.DataSource = dt;
                    con.Close();
                    
            }
            catch (Exception)
            {

            }

        }

        private void comprasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rellenarDT()
        {
            MySqlConnection con3 = new MySqlConnection(CM_Login.cone);
            {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Compras where Comprador = '"+CM_Login.user+"'", con3))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvC.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void rellenarDTAdmin()
        {
            MySqlConnection con4 = new MySqlConnection(CM_Login.cone);
            {
                using (MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM Compras", con4))
                {
                    cmd2.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2))
                    {
                        using (DataTable dt2 = new DataTable())
                        {
                            sda2.Fill(dt2);
                            dgvC.DataSource = dt2;
                        }
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCompras form = new SelectCompras();
            form.Show();
            form.TopMost = true;
            form.Activate();
        }

        private void txbCan_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyData != Keys.Back)
                e.SuppressKeyPress = !int.TryParse(Convert.ToString((char)e.KeyData), out int _);
        } // restringe el ingreso de datos a solo numeros

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbCan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNotas_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txbNotas_KeyDown(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgvC_VisibleChanged(object sender, System.EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (rbU.Checked)
             {
                tipoPre ="Precio_X_Unidad";
            }
            else { tipoPre = "Precio_X_Kilo"; }

            if (cbPro.Text == "Fosforo" || cbPro.Text == "Nitrogeno")
            {
                rbU.Text = "kg";
                rbK.Hide();
            }
            else {
                rbU.Text = "Unidad";
                rbK.Show(); }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txbNotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // restringe el ingreso de datos a solo letras
            }
        }

        private void admin_Tick(object sender, EventArgs e)
        {
            this.rellenarDTAdmin();
        }

       

        private void otro_Tick_1(object sender, EventArgs e)
        {
            this.rellenarDT();
        }

        private void CCompras_MouseDown(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
