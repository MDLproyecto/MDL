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
using MySql.Data.MySqlClient;
using CapaModelo2;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class Compras : Form
    {
        SqlConnection con = new SqlConnection(CM_Login.cone);

        public Compras()
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

            Fecha.Start();
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("select (Tipo_De_Semilla) from Semillas", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Tipo_De_Semilla", typeof(string));
                dt.Load(reader);
                cbPro.ValueMember = "Tipo_De_Semilla";
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
           
        }
    }
}
