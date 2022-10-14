namespace WindowsFormsApp2
{
    partial class Compras
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCan = new System.Windows.Forms.TextBox();
            this.cbPro = new System.Windows.Forms.ComboBox();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.comprasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ke_FrutaCompras = new WindowsFormsApp2.Ke_FrutaCompras();
            this.btnCo = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.comprasTableAdapter = new WindowsFormsApp2.Ke_FrutaComprasTableAdapters.ComprasTableAdapter();
            this.btnEli = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ke_FrutaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema De Compras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbPa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblClock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbCan);
            this.groupBox1.Controls.Add(this.cbPro);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area de Ventas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(532, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tipo de Pago:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbPa
            // 
            this.cbPa.FormattingEnabled = true;
            this.cbPa.Items.AddRange(new object[] {
            "Tarjeta de credito",
            "Tarjeta de debito",
            "Efectivo"});
            this.cbPa.Location = new System.Drawing.Point(530, 67);
            this.cbPa.Name = "cbPa";
            this.cbPa.Size = new System.Drawing.Size(176, 21);
            this.cbPa.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(776, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha y Hora Actual";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDate.Location = new System.Drawing.Point(772, 102);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(191, 40);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "23/07/2022";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(128)))), ((int)(((byte)(38)))));
            this.lblClock.Location = new System.Drawing.Point(755, 45);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(222, 57);
            this.lblClock.TabIndex = 22;
            this.lblClock.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(321, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "*El pago se le acreditara a su cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar Producto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbCan
            // 
            this.txbCan.Location = new System.Drawing.Point(326, 66);
            this.txbCan.Name = "txbCan";
            this.txbCan.Size = new System.Drawing.Size(93, 20);
            this.txbCan.TabIndex = 2;
            // 
            // cbPro
            // 
            this.cbPro.FormattingEnabled = true;
            this.cbPro.Location = new System.Drawing.Point(16, 66);
            this.cbPro.Name = "cbPro";
            this.cbPro.Size = new System.Drawing.Size(176, 21);
            this.cbPro.TabIndex = 0;
            // 
            // dgvC
            // 
            this.dgvC.AllowUserToAddRows = false;
            this.dgvC.AllowUserToDeleteRows = false;
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(12, 230);
            this.dgvC.Name = "dgvC";
            this.dgvC.ReadOnly = true;
            this.dgvC.Size = new System.Drawing.Size(983, 164);
            this.dgvC.TabIndex = 2;
            // 
            // comprasBindingSource1
            // 
            this.comprasBindingSource1.DataMember = "Compras";
            this.comprasBindingSource1.DataSource = this.ke_FrutaCompras;
            // 
            // ke_FrutaCompras
            // 
            this.ke_FrutaCompras.DataSetName = "Ke_FrutaCompras";
            this.ke_FrutaCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCo
            // 
            this.btnCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCo.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCo.Location = new System.Drawing.Point(811, 400);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(184, 34);
            this.btnCo.TabIndex = 5;
            this.btnCo.Text = "Comprar";
            this.btnCo.UseVisualStyleBackColor = false;
            this.btnCo.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fecha
            // 
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // btnEli
            // 
            this.btnEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEli.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEli.Location = new System.Drawing.Point(12, 400);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(184, 34);
            this.btnEli.TabIndex = 22;
            this.btnEli.Text = "Eliminar Compra";
            this.btnEli.UseVisualStyleBackColor = false;
            this.btnEli.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gray;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.minimizar_signo;
            this.pictureBox6.Location = new System.Drawing.Point(933, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(967, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1005, 446);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ke_FrutaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCan;
        private System.Windows.Forms.ComboBox cbPro;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compradorDataGridViewTextBoxColumn;
        private Ke_FrutaCompras ke_FrutaCompras;
        private System.Windows.Forms.BindingSource comprasBindingSource1;
        private Ke_FrutaComprasTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPa;
        private System.Windows.Forms.Button btnEli;
    }
}