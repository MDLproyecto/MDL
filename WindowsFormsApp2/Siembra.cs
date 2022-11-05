using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//DLLs para mover el form
using System.Data.SqlClient; //SQL
using MySql.Data.MySqlClient; //MYSQL
using CapaModelo2;
using CapaDatos2;

namespace WindowsFormsApp2
{
    public partial class Siembra : Form
    {
        MySqlConnection con = new MySqlConnection(CM_Login.cone);
        public static int i =0;
        public static string btn;

        //Esto es para que se pueda mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Siembra()
        {

            InitializeComponent();
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

        private void Siembra_MouseDown(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Siembra_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void Siembra_Load(object sender, EventArgs e)
        {
            fin.Start();

            try
            {
                con.Open();
                MySqlCommand sc = new MySqlCommand("select (Nombre) from Compras where Comprador = '" + CM_Login.user + "' AND IoS='1'", con);
                MySqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Nombre", typeof(string));
                dt.Load(reader);
                cbS.ValueMember = "Nombre";
                cbS.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }

            actualizar.Start();
            CD_Siembra.siembra();
            CM_Siembra.Nitra = tbNitra.Value;
            


           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void tbEtapa_Scroll(object sender, EventArgs e)
        {
       

            lblDN.Text = CM_Siembra.NitroDosis.ToString();
            lblDF.Text = CM_Siembra.FosfoDosis.ToString();
            lblNT.Text = CM_Siembra.Ntotal.ToString();
            lblFT.Text = CM_Siembra.Ptotal.ToString();
        }

        private void lblEtapa_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTF_Click(object sender, EventArgs e)
        {

        }

        private void tbNi_Scroll(object sender, EventArgs e)
        {
            CM_Siembra.Nitra = tbNitra.Value;
        }

        private void etapa_Tick(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblEtapa_TextChanged(object sender, EventArgs e)
        {
            CD_Siembra.Fertilizacion();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CM_Siembra.Ps = tbPs.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            CM_Siembra.Ns = tbNs.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public static void Total(MySqlConnection con)
        {
                con.Open();
                MySqlCommand query1 = new MySqlCommand("select Cantidad from Inv where Comprador='" + CM_Login.user + "' AND Nombre='Nitrogeno';", con);
                CM_Siembra.NitroDis = Convert.ToInt32(query1.ExecuteScalar());
                MySqlCommand query2 = new MySqlCommand("select Cantidad from Inv where Comprador='" + CM_Login.user + "' AND Nombre='Fosforo';", con);
                CM_Siembra.FosfoDis = Convert.ToInt32(query2.ExecuteScalar());
                i = 1;

                con.Close();
            

        }

        private void actualizar_Tick(object sender, EventArgs e)
        {
            
            CM_Siembra.Sector = "Noroeste";
            
            btn = grb_S.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;

            switch (btn)
            {
                case "rbNoroeste":
                    CM_Siembra.Sector = "Noroeste";
                    break;
                case "rbNorte":
                    CM_Siembra.Sector = "Norte";
                    break;
                case "rbNoreste":
                    CM_Siembra.Sector = "Noreste";
                    break;
                case "rbOeste":
                    CM_Siembra.Sector = "Oeste";
                    break;
                case "rbCentro":
                    CM_Siembra.Sector = "Centro";
                    break;
                case "rbEste":
                    CM_Siembra.Sector = "Este";
                    break;
                case "rbSuroeste":
                    CM_Siembra.Sector = "Suroeste";
                    break;
                case "rbSur":
                    CM_Siembra.Sector = "Sur";
                    break;
                case "rbSureste":
                    CM_Siembra.Sector = "Sureste";
                    break;
                default:

                    break;
            }

            switch (lblEstado.Text)
            {

                case "Disponible":
                    pictureBox1.Image = Properties.Resources.CVacio;

                    break;

                case "En proceso":
                    pictureBox1.Image = Properties.Resources.CPlantado;

                    break;

                case "Listo para cosechar":
                    pictureBox1.Image = Properties.Resources.CListo;

                    break;
                case "Descanso":
                    pictureBox1.Image = Properties.Resources.CVacio;

                    break;

                default:

                    break;
            }

            CD_Siembra.siembra();
            lblNDispo.Text = CM_Siembra.NitroDis.ToString();
            lblFDispo.Text = CM_Siembra.FosfoDis.ToString();
            lblSA.Text = CM_Siembra.Sector;

            lblNitra.Text = CM_Siembra.Nitra.ToString();
            lblFos.Text = CM_Siembra.Ps.ToString();
            lblNitroS.Text = CM_Siembra.Ns.ToString();
            if (CM_Siembra.r > 1)
            {
                lblEstado.Text = CM_Siembra.Estado.ToString();

                lblPA.Text = CM_Siembra.Plantacion.ToString();
            }
            CM_Siembra.ss = cbS.Text;

            if (CM_Siembra.Estado != null)
            {
                lblEstado.Text = CM_Siembra.Estado.ToString();
            }
            if (CM_Siembra.Plantacion != null)
            {
                lblPA.Text = CM_Siembra.Plantacion.ToString();
            }
            if (CM_Siembra.Fin != null)
            {
                lblResE.Text = CM_Siembra.Fin.ToString();
            }
            if (CM_Siembra.Inicio != null)
            {
                lblResC.Text = CM_Siembra.Inicio.ToString();
            }
          

            Total(con);



            switch (CM_Siembra.Etapa)
            {
                case 0:
                    LblFosfo.Text = "";
                    lblFer.Text = "";
                    break;
                case 1:
                    lblFer.Text = "Nitra";
                    LblFosfo.Text = "+Fosforo";
                    break;
                case 2:
                    LblFosfo.Text = "";
                    lblFer.Text = "Z2.2";
                    break;
                case 3:
                    lblFer.Text = "Encañado";
                    break;
                default:
                    LblFosfo.Text = "";
                    lblFer.Text = "";
                    break;
            }


            

            

        }

            




        

        private void txbNp_TextChanged(object sender, EventArgs e)
        {
            if (txbNp.Text != "") { 
            CM_Siembra.Np = double.Parse (txbNp.Text);
            }
        }

        private void txbNp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // solo permite un punto
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblEstado.Text == "Listo para cosechar")
            {
                CD_Siembra.rotacion();
            }
            else
            { MessageBox.Show("NO ESTA LISTO PARA COSECHAR!!!"); }
        }

        private void btnTuto_Click(object sender, EventArgs e)
        {
            
            // esconde siembra
            this.Hide();
            // crea la instancia del tutorial
            Simulacion form = new Simulacion();
            // muestra el tutorial
            form.ShowDialog();
            form = null;
            // cuando se cierra el tutorial se abre la siembra
            this.Show();
        }

        private void res_Tick(object sender, EventArgs e)
        {

            
        }


        private void btnPla_Click(object sender, EventArgs e)
        {
            if (lblEstado.Text == "Disponible") {
                CD_Siembra.Plantar();
            } else {MessageBox.Show("ESTE SECTOR NO ESTA DISPONIBLE!!!");}
        }

        private void lblSA_TextChanged(object sender, EventArgs e)
        {
            CD_Siembra.siembra();
            switch (lblEstado.Text)
            {

                case "Disponible":
                    pictureBox1.Image = Properties.Resources.CVacio;

                    break;

                case "En proceso":
                    pictureBox1.Image = Properties.Resources.CPlantado;

                    break;

                case "Listo para cosechar":
                    pictureBox1.Image = Properties.Resources.CListo;

                    break;
                case "Descanso":
                    pictureBox1.Image = Properties.Resources.CVacio;

                    break;

                default:

                    break;
            }
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void fin_Tick(object sender, EventArgs e)
        {
            CD_Siembra.fin();
        }
    }
}

