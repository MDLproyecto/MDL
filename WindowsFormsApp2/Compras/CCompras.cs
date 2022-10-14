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

namespace WindowsFormsApp2
{
    public partial class CCompras : Form
    {
        MySqlConnection con = new MySqlConnection(CM_Login.cone);
        int can;
        string tipoPre;
        int pr=1;
 
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
                    MySqlCommand query2= new MySqlCommand("insert into Compras(Nombre,Cantidad,Precio,Precio_Final,Fecha_Actual,Hora_Actual,Comprador,Tipo_de_Pago,Notas) values('"+cbPro.Text+"', '"+can+"', '"+pr+"', '"+prf+"', '"+lblDate.Text+ "', '"+lblClock.Text+"', '"+CM_Login.nombr+"', '"+cbPa.Text+"', '"+txbNotas.Text+"');",con);
                    int r = query2.ExecuteNonQuery();

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
            this.rellenarDT();
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
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Compras", con3))
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
            this.rellenarDT();
            if (rbU.Checked)
             {
                tipoPre ="Precio_X_Unidad";
            }
            else { tipoPre = "Precio_X_Kilo"; }
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
    }
}
