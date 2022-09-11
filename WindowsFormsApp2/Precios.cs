using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;//DLLs para mover el form

namespace WindowsFormsApp2
{
    public partial class Precios : Form
    {
        //Esto es para que se pueda mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Precios()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OB3T54G\\SQLEXPRESS;Initial Catalog=Ke_Fruta; Integrated Security=True");

        private void Precios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ke_FrutaSemillas.Semillas' table. You can move, or remove it, as needed.
            this.semillasTableAdapter.Fill(this.ke_FrutaSemillas.Semillas);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AUsuario_MouseUp(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            //Esto permite arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
