namespace WindowsFormsApp2
{
    partial class Precios
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
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.semillasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ke_FrutaSemillas = new WindowsFormsApp2.Ke_FrutaSemillas();
            this.semillasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.semillasTableAdapter = new WindowsFormsApp2.Ke_FrutaSemillasTableAdapters.SemillasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semillasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ke_FrutaSemillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semillasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvP
            // 
            this.dgvP.AllowUserToAddRows = false;
            this.dgvP.AllowUserToDeleteRows = false;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(12, 29);
            this.dgvP.Name = "dgvP";
            this.dgvP.Size = new System.Drawing.Size(343, 293);
            this.dgvP.TabIndex = 0;
            this.dgvP.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dgvP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dgvP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // semillasBindingSource1
            // 
            this.semillasBindingSource1.DataMember = "Semillas";
            this.semillasBindingSource1.DataSource = this.ke_FrutaSemillas;
            // 
            // ke_FrutaSemillas
            // 
            this.ke_FrutaSemillas.DataSetName = "Ke_FrutaSemillas";
            this.ke_FrutaSemillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(338, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // semillasTableAdapter
            // 
            this.semillasTableAdapter.ClearBeforeFill = true;
            // 
            // Precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(368, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Precios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUsuario";
            this.Load += new System.EventHandler(this.Precios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AUsuario_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AUsuario_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semillasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ke_FrutaSemillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semillasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource semillasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSemillaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeSemillaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioXKiloDataGridViewTextBoxColumn;
        private Ke_FrutaSemillas ke_FrutaSemillas;
        private System.Windows.Forms.BindingSource semillasBindingSource1;
        private Ke_FrutaSemillasTableAdapters.SemillasTableAdapter semillasTableAdapter;
    }
}