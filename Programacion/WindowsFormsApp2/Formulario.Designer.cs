namespace WindowsFormsApp2
{
    partial class Formulario
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
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.adminContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.accionesContainer = new System.Windows.Forms.Panel();
            this.panelFin = new System.Windows.Forms.Panel();
            this.btnFin = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnVen = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnIns = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.accionesTimer = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.adminContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.accionesContainer.SuspendLayout();
            this.panelFin.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(3, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 35);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "admin";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.KeFruta;
            this.pictureBox5.Location = new System.Drawing.Point(370, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(307, 272);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Image = global::WindowsFormsApp2.Properties.Resources.adminMenu2;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(-34, -24);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(251, 87);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // adminContainer
            // 
            this.adminContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminContainer.Controls.Add(this.panel3);
            this.adminContainer.Controls.Add(this.panel2);
            this.adminContainer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminContainer.Location = new System.Drawing.Point(3, 109);
            this.adminContainer.MaximumSize = new System.Drawing.Size(200, 100);
            this.adminContainer.MinimumSize = new System.Drawing.Size(200, 40);
            this.adminContainer.Name = "adminContainer";
            this.adminContainer.Size = new System.Drawing.Size(200, 40);
            this.adminContainer.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 53);
            this.panel3.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp2.Properties.Resources.submenu;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-34, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(231, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Configurar Precios";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 53);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // adminTimer
            // 
            this.adminTimer.Interval = 10;
            this.adminTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.adminContainer);
            this.sidebar.Controls.Add(this.accionesContainer);
            this.sidebar.Controls.Add(this.userPanel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(210, 610);
            this.sidebar.MinimumSize = new System.Drawing.Size(45, 610);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(210, 610);
            this.sidebar.TabIndex = 16;
            this.sidebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidebar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Menu";
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pictureBoxMenu.Image = global::WindowsFormsApp2.Properties.Resources._588a6507d06f6719692a2d15;
            this.pictureBoxMenu.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(39, 44);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 17;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // accionesContainer
            // 
            this.accionesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accionesContainer.Controls.Add(this.panelFin);
            this.accionesContainer.Controls.Add(this.panel8);
            this.accionesContainer.Controls.Add(this.panel6);
            this.accionesContainer.Controls.Add(this.panel7);
            this.accionesContainer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accionesContainer.Location = new System.Drawing.Point(3, 155);
            this.accionesContainer.MaximumSize = new System.Drawing.Size(200, 216);
            this.accionesContainer.MinimumSize = new System.Drawing.Size(200, 44);
            this.accionesContainer.Name = "accionesContainer";
            this.accionesContainer.Size = new System.Drawing.Size(200, 44);
            this.accionesContainer.TabIndex = 19;
            // 
            // panelFin
            // 
            this.panelFin.BackColor = System.Drawing.Color.Gray;
            this.panelFin.Controls.Add(this.btnFin);
            this.panelFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelFin.Location = new System.Drawing.Point(3, 161);
            this.panelFin.Name = "panelFin";
            this.panelFin.Size = new System.Drawing.Size(200, 53);
            this.panelFin.TabIndex = 19;
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.Gray;
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Image = global::WindowsFormsApp2.Properties.Resources.submenu;
            this.btnFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFin.Location = new System.Drawing.Point(-34, 0);
            this.btnFin.Name = "btnFin";
            this.btnFin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFin.Size = new System.Drawing.Size(231, 55);
            this.btnFin.TabIndex = 4;
            this.btnFin.Text = "Comprar Productos Finales";
            this.btnFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFin.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.btnVen);
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(3, 102);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 53);
            this.panel8.TabIndex = 19;
            // 
            // btnVen
            // 
            this.btnVen.BackColor = System.Drawing.Color.Gray;
            this.btnVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVen.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVen.Image = global::WindowsFormsApp2.Properties.Resources.submenu;
            this.btnVen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVen.Location = new System.Drawing.Point(-34, 0);
            this.btnVen.Name = "btnVen";
            this.btnVen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVen.Size = new System.Drawing.Size(231, 55);
            this.btnVen.TabIndex = 4;
            this.btnVen.Text = "Vender";
            this.btnVen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVen.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.btnIns);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(3, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 53);
            this.panel6.TabIndex = 18;
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.Gray;
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.Image = global::WindowsFormsApp2.Properties.Resources.submenu;
            this.btnIns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIns.Location = new System.Drawing.Point(-34, 0);
            this.btnIns.Name = "btnIns";
            this.btnIns.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnIns.Size = new System.Drawing.Size(231, 55);
            this.btnIns.TabIndex = 4;
            this.btnIns.Text = "Comprar Insumos";
            this.btnIns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIns.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button3);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 53);
            this.panel7.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApp2.Properties.Resources.carpeta;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-34, -24);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(251, 87);
            this.button3.TabIndex = 4;
            this.button3.Text = "Acciones";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userPanel.Controls.Add(this.lblUser);
            this.userPanel.Controls.Add(this.pictureBox1);
            this.userPanel.Location = new System.Drawing.Point(3, 205);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(200, 100);
            this.userPanel.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.minimizar_signo;
            this.pictureBox6.Location = new System.Drawing.Point(894, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(928, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 20;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // accionesTimer
            // 
            this.accionesTimer.Interval = 10;
            this.accionesTimer.Tick += new System.EventHandler(this.accionesTimer_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(128)))), ((int)(((byte)(38)))));
            this.lblClock.Location = new System.Drawing.Point(0, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(222, 57);
            this.lblClock.TabIndex = 20;
            this.lblClock.Text = "00:00:00";
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDate.Location = new System.Drawing.Point(17, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(191, 40);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "23/07/2022";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.lblClock);
            this.panel4.Location = new System.Drawing.Point(732, 496);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 102);
            this.panel4.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 550);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(130, 43);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(261, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Datagrid";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._20535105;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooperativa";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Formulario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.adminContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.accionesContainer.ResumeLayout(false);
            this.panelFin.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel adminContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer adminTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel accionesContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelFin;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer accionesTimer;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}