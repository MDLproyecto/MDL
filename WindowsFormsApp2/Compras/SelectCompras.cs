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

namespace WindowsFormsApp2.Compras
{
    public partial class SelectCompras : Form
    {
        MySqlConnection con = new MySqlConnection(CM_Login.cone);
        public SelectCompras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectCompras_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand sc = new MySqlCommand("select (Id_Compra) from Compras", con);
                MySqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id_Compra", typeof(string));
                dt.Load(reader);
                cbN.ValueMember = "Id_Compra";
                cbN.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            // esconde el formulario 2
            this.Hide();
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand query = new MySqlCommand("DELETE FROM Compras WHERE Id_Compra="+cbN.Text+";",con);
            int r = query.ExecuteNonQuery();
            
            if (r > 0)
            {
                MessageBox.Show("Datos Eliminados");
            }
            else
            {
                MessageBox.Show("ERROR Contacta a un administrador");
            }
            con.Close();
            this.Hide();
        }
    }
}
