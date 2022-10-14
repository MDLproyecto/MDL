namespace WindowsFormsApp2
{
    partial class AUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvU = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ke_FrutaUsuarios = new WindowsFormsApp2.Ke_FrutaUsuarios();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuariosTableAdapter = new WindowsFormsApp2.Ke_FrutaUsuariosTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ke_FrutaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvU
            // 
            this.dgvU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvU.Location = new System.Drawing.Point(12, 28);
            this.dgvU.Name = "dgvU";
            this.dgvU.Size = new System.Drawing.Size(896, 293);
            this.dgvU.TabIndex = 0;
            this.dgvU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dgvU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dgvU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.ke_FrutaUsuarios;
            // 
            // ke_FrutaUsuarios
            // 
            this.ke_FrutaUsuarios.DataSetName = "Ke_FrutaUsuarios";
            this.ke_FrutaUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(887, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // AUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(920, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUsuario";
            this.Load += new System.EventHandler(this.Precios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AUsuario_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AUsuario_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ke_FrutaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvU;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.BindingSource usuariosBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioDataGridViewTextBoxColumn;
        private Ke_FrutaUsuarios ke_FrutaUsuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private Ke_FrutaUsuariosTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}