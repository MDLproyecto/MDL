using CapaModelo2;
using CapaDatos2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//DLLs para mover el login
using System.Data.SqlClient; //SQL

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        CD_Login cn = new CD_Login();

        //Esto es para que se pueda mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        public Login()
        {
            
            InitializeComponent();


            
        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Ke_Fruta; Integrated Security=True");


        

        public void log(String usuario, string contrasena)
        {
                if (cn.conSQL(txtU.Text, txtC.Text) == 1)
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Nombres,Tipo_usuario,CI,Email,Telefono FROM usuarios WHERE Usuario = @usuario AND Password = @pas ", con);

                    cmd.Parameters.AddWithValue("usuario", usuario);
                    cmd.Parameters.AddWithValue("pas", contrasena);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataReader dr = cmd.ExecuteReader();

                this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        CM_Login.tipo = "admin";
                        // esconde el formulario 1
                        this.Hide();
                        // crea la instancia del formulario 2
                        Menu f2 = new Menu();
                        // muestra el formulario 2
                        f2.ShowDialog();
                        f2 = null;
                        // cuando se cierra el formulario 2 se abre el 1
                        this.Show();
                        CM_Login.corre = true;
                    }
                    else if (dt.Rows[0][1].ToString() == "Productor")
                    {
                        CM_Login.tipo = "productor";
                        // esconde el formulario 1
                        this.Hide();
                        // crea la instancia del formulario 2
                        Menu f2 = new Menu();
                        // muestra el formulario 2
                        f2.ShowDialog();
                        f2 = null;
                        // cuando se cierra el formulario 2 se abre el 1
                        this.Show();
                        CM_Login.corre = true;
                    }

                    else if (dt.Rows[0][1].ToString() == "Cliente")
                    {
                        CM_Login.tipo = "cliente";
                        // esconde el formulario 1
                        this.Hide();
                        // crea la instancia del formulario 2
                        Menu f2 = new Menu();
                        // muestra el formulario 2
                        f2.ShowDialog();
                        f2 = null;
                        // cuando se cierra el formulario 2 se abre el 1
                        this.Show();
                        CM_Login.corre = true;
                    }

                }
                else
                {
                    if (txtU.Text == "USUARIO" && txtC.Text == "CONTRASEÑA" || txtU.Text == "" && txtC.Text == "")
                    {
                        MessageBox.Show("Tienes que ingresar algun dato!");
                        CM_Login.corre = true;
                    }
                    else
                        CM_Login.corre = false;
                    {
                        if (CM_Login.corre == false)
                        {


                            CM_Login.inte--;
                            MessageBox.Show("Usuario y/o clave incorrectos.");
                            VaciarTxt();
                            if (CM_Login.inte == 0)
                            {
                                MessageBox.Show("Ha llegado al número máximo de intentos.");
                                Application.Exit();
                            }
                        }

                    } 
                con.Close();
            }
        }

        public void VaciarTxt()
        {
            txtC.Text = "";
            txtU.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnOk;
        }

        



        private void btnOk_Click(object sender, EventArgs e)
        {
            CM_Login.user = txtU.Text;
            CM_Login.contra = txtC.Text;

            log(this.txtU.Text, this.txtC.Text);
             
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            
        }

        public void txtU_TextChanged(object sender, EventArgs e)
        {
            string user = txtU.Text;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            string contra = txtC.Text;
        
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100) {
                timer1.Stop();
                }

        }

        private void txtU_Enter(object sender, EventArgs e)
        {
            if (txtU.Text == "USUARIO")
            {
                txtU.Text = "";
                txtU.ForeColor = Color.LightGray;
            }
        }

        private void txtU_Leave(object sender, EventArgs e)
        {
            if (txtU.Text == "")
            {
                txtU.Text = "USUARIO";
                txtU.ForeColor = Color.DimGray;
            }
        }

       

      

        private void txtC_Enter_1(object sender, EventArgs e)
        {
            if (txtC.Text == "CONTRASEÑA")
            {
                txtC.Text = "";
                txtC.ForeColor = Color.LightGray;
                txtC.UseSystemPasswordChar = true;
            }
        }

        private void txtC_Leave_1(object sender, EventArgs e)
        {
            if (txtC.Text == "")
            {
                txtC.Text = "CONTRASEÑA";
                txtC.ForeColor = Color.DimGray;
                txtC.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Boton para mostrar contraseña
            if (txtC.Text != "CONTRASEÑA")
            {
                
            if (CM_Login.eye == 0)
            {
                txtC.UseSystemPasswordChar = false;
                    CM_Login.eye = 1;
            } else
            {
                    CM_Login.eye = 0;
                txtC.UseSystemPasswordChar = true;
            }
            }
        }
    }
}

