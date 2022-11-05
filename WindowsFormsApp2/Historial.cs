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
    public partial class Historial : Form
    {
        //Esto es para que se pueda mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        MySqlConnection con = new MySqlConnection(CM_Login.cone);
        public Historial()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // esconde el formulario 2
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            if (CM_Login.tipo == "admin")
            {
                this.admin.Start();
            }
            else
            {
                this.otro.Start();
            }
            
        }

        private void rellenarDTAdmin()
        {
            MySqlConnection con4 = new MySqlConnection(CM_Login.cone);
            {
                using (MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM Historial", con4))
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

        private void admin_Tick(object sender, EventArgs e)
        {
            this.rellenarDTAdmin();
        }

        private void Historial_MouseDown(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void otro_Tick(object sender, EventArgs e)
        {
            MySqlConnection con4 = new MySqlConnection(CM_Login.cone);
            {
                using (MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM Historial where Comprador = '" + CM_Login.user + "'", con4))
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
    }
}
