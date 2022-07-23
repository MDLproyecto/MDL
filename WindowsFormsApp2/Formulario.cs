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

namespace WindowsFormsApp2
{



    public partial class Formulario : Form
    {

        //Esto es para que se pueda mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public Boolean adminColapsado = true;
        public Boolean accionesColapsado = true;
        Boolean sidebarExpand;
        public Formulario()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

            sidebarExpand = true;

            lblUser.Text = Form1.user;
            switch (Form1.user)
            {
                // asigna propiedades a los usuarios
                case "admin":
                    pictureBox1.Image = Properties.Resources.admin; // selecciona la foto del admin

                    adminContainer.Visible = true; // Activa el poder ver el menu admin
                    btnVen.Visible = true; // Boton venta visible
                    btnFin.Visible = true; // Boton compra de productos finales visible
                    break;

                case "productor":
                    pictureBox1.Image = Properties.Resources.productor; // selecciona la foto del productor

                    adminContainer.Visible = false; // Desactiva el poder ver el menu admin
                    btnVen.Visible = true; // Boton venta visible
                    panelFin.Visible = false; // Boton compra de productos finales invisible
                    break;

                case "cliente":
                    pictureBox1.Image = Properties.Resources.user; // selecciona la foto del cliente

                    adminContainer.Visible = false; // Desactiva el poder ver el menu admin
                    btnVen.Visible = false; // Boton venta invisible
                    panelFin.Visible = true; // Boton compra de productos finales visible
                    break;

                default:
  
                    break;
            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // esconde el formulario 2
            this.Hide();
            
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //animacion cerrar y abrir 
            if (adminColapsado)
                {
                adminContainer.Height += 10;
                if (adminContainer.Height == adminContainer.MaximumSize.Height)
                {
                    adminTimer.Stop();
                    adminColapsado = false;

                }
            }else{
                adminContainer.Height -= 10;
                if (adminContainer.Height == adminContainer.MinimumSize.Height)
                {
                    adminTimer.Stop();
                    adminColapsado = true;
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            accionesTimer.Start();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // esconde el formulario 2
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //animacion cerrar y abrir 
            if (sidebarExpand == true)
            {
                sidebar.Width -= 20;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {

                    sidebarTimer.Stop();
                    sidebarExpand = false;
                    userPanel.Visible = false;

                }
            } else
                {
                        sidebar.Width += 20;
                userPanel.Visible = true;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        
                        sidebarTimer.Stop();
                        sidebarExpand = true;
                        
                }
                    
                }
            }
            
        

        private void accionesTimer_Tick(object sender, EventArgs e)
        {
            if (accionesColapsado)
            {
                accionesContainer.Height += 10;
                if (accionesContainer.Height == accionesContainer.MaximumSize.Height)
                {
                    accionesTimer.Stop();
                    accionesColapsado = false;
                }
            }
            else
            {
                accionesContainer.Height -= 10;
                if (accionesContainer.Height == accionesContainer.MinimumSize.Height)
                {
                    accionesTimer.Stop();
                    accionesColapsado = true;
                }
            }
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
           
        }

        private void Formulario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void sidebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("d");
        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }
    }
}
