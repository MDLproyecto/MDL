namespace WindowsFormsApp2
{
    partial class Simulacion
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
            this.lblFosforo = new System.Windows.Forms.GroupBox();
            this.LblFosfo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.lblFer = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblFDispo = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.lblTF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblNDispo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txbNp = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.lblNitroS = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lblFos = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblNitra = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbNs = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPs = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFT = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.Label();
            this.lblNT = new System.Windows.Forms.Label();
            this.lblDF = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNitra = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.tbEtapa = new System.Windows.Forms.TrackBar();
            this.etapa = new System.Windows.Forms.Timer(this.components);
            this.actualizar = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lblFosforo.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPs)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNitra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEtapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFosforo
            // 
            this.lblFosforo.Controls.Add(this.LblFosfo);
            this.lblFosforo.Controls.Add(this.label18);
            this.lblFosforo.Controls.Add(this.groupBox14);
            this.lblFosforo.Controls.Add(this.groupBox10);
            this.lblFosforo.Controls.Add(this.groupBox8);
            this.lblFosforo.Controls.Add(this.groupBox7);
            this.lblFosforo.Controls.Add(this.groupBox2);
            this.lblFosforo.Controls.Add(this.label5);
            this.lblFosforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFosforo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFosforo.Location = new System.Drawing.Point(12, 41);
            this.lblFosforo.Name = "lblFosforo";
            this.lblFosforo.Size = new System.Drawing.Size(569, 345);
            this.lblFosforo.TabIndex = 39;
            this.lblFosforo.TabStop = false;
            this.lblFosforo.Text = "Fertilizacion (Trigo y Cebada)";
            this.lblFosforo.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // LblFosfo
            // 
            this.LblFosfo.AutoSize = true;
            this.LblFosfo.BackColor = System.Drawing.Color.Transparent;
            this.LblFosfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblFosfo.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFosfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblFosfo.Location = new System.Drawing.Point(121, 85);
            this.LblFosfo.Name = "LblFosfo";
            this.LblFosfo.Size = new System.Drawing.Size(77, 23);
            this.LblFosfo.TabIndex = 52;
            this.LblFosfo.Text = "+Fosforo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(2, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 16);
            this.label18.TabIndex = 52;
            this.label18.Text = "Fertilizacion actual:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.lblFer);
            this.groupBox14.Location = new System.Drawing.Point(120, 42);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(80, 44);
            this.groupBox14.TabIndex = 49;
            this.groupBox14.TabStop = false;
            this.groupBox14.Enter += new System.EventHandler(this.groupBox14_Enter);
            // 
            // lblFer
            // 
            this.lblFer.AutoSize = true;
            this.lblFer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFer.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFer.Location = new System.Drawing.Point(1, 16);
            this.lblFer.Name = "lblFer";
            this.lblFer.Size = new System.Drawing.Size(49, 23);
            this.lblFer.TabIndex = 52;
            this.lblFer.Text = "Nitra";
            this.lblFer.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblFDispo);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox10.Location = new System.Drawing.Point(37, 256);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(125, 82);
            this.groupBox10.TabIndex = 51;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "F disponible";
            // 
            // lblFDispo
            // 
            this.lblFDispo.AutoSize = true;
            this.lblFDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFDispo.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDispo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFDispo.Location = new System.Drawing.Point(20, 28);
            this.lblFDispo.Name = "lblFDispo";
            this.lblFDispo.Size = new System.Drawing.Size(84, 28);
            this.lblFDispo.TabIndex = 50;
            this.lblFDispo.Text = "000000";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblEtapa);
            this.groupBox8.Controls.Add(this.lblTF);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Location = new System.Drawing.Point(47, 98);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(106, 66);
            this.groupBox8.TabIndex = 50;
            this.groupBox8.TabStop = false;
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEtapa.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEtapa.Location = new System.Drawing.Point(5, 13);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(37, 42);
            this.lblEtapa.TabIndex = 47;
            this.lblEtapa.Text = "0";
            this.lblEtapa.TextChanged += new System.EventHandler(this.lblEtapa_TextChanged);
            this.lblEtapa.Click += new System.EventHandler(this.lblEtapa_Click);
            // 
            // lblTF
            // 
            this.lblTF.AutoSize = true;
            this.lblTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTF.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTF.Location = new System.Drawing.Point(67, 14);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(36, 42);
            this.lblTF.TabIndex = 46;
            this.lblTF.Text = "9";
            this.lblTF.Click += new System.EventHandler(this.lblTF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(39, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 42);
            this.label2.TabIndex = 48;
            this.label2.Text = "/";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblNDispo);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox7.Location = new System.Drawing.Point(37, 167);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(125, 82);
            this.groupBox7.TabIndex = 49;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "N disponible";
            // 
            // lblNDispo
            // 
            this.lblNDispo.AutoSize = true;
            this.lblNDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNDispo.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNDispo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNDispo.Location = new System.Drawing.Point(20, 28);
            this.lblNDispo.Name = "lblNDispo";
            this.lblNDispo.Size = new System.Drawing.Size(84, 28);
            this.lblNDispo.TabIndex = 50;
            this.lblNDispo.Text = "000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox15);
            this.groupBox2.Controls.Add(this.groupBox13);
            this.groupBox2.Controls.Add(this.groupBox12);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tbNs);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbPs);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.tbNitra);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(205, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 316);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Niveles";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.txbNp);
            this.groupBox11.Location = new System.Drawing.Point(188, 240);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(159, 49);
            this.groupBox11.TabIndex = 81;
            this.groupBox11.TabStop = false;
            // 
            // txbNp
            // 
            this.txbNp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txbNp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbNp.Location = new System.Drawing.Point(4, 15);
            this.txbNp.Name = "txbNp";
            this.txbNp.Size = new System.Drawing.Size(151, 29);
            this.txbNp.TabIndex = 80;
            this.txbNp.Text = "0.00";
            this.txbNp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNp.TextChanged += new System.EventHandler(this.txbNp_TextChanged);
            this.txbNp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNp_KeyPress);
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.Transparent;
            this.groupBox15.Controls.Add(this.lblNitroS);
            this.groupBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox15.Location = new System.Drawing.Point(68, 268);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(47, 38);
            this.groupBox15.TabIndex = 79;
            this.groupBox15.TabStop = false;
            // 
            // lblNitroS
            // 
            this.lblNitroS.AutoSize = true;
            this.lblNitroS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNitroS.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitroS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNitroS.Location = new System.Drawing.Point(12, 9);
            this.lblNitroS.Name = "lblNitroS";
            this.lblNitroS.Size = new System.Drawing.Size(36, 28);
            this.lblNitroS.TabIndex = 51;
            this.lblNitroS.Text = "00";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Transparent;
            this.groupBox13.Controls.Add(this.lblFos);
            this.groupBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox13.Location = new System.Drawing.Point(244, 177);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(47, 38);
            this.groupBox13.TabIndex = 77;
            this.groupBox13.TabStop = false;
            // 
            // lblFos
            // 
            this.lblFos.AutoSize = true;
            this.lblFos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFos.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFos.Location = new System.Drawing.Point(13, 9);
            this.lblFos.Name = "lblFos";
            this.lblFos.Size = new System.Drawing.Size(36, 28);
            this.lblFos.TabIndex = 51;
            this.lblFos.Text = "00";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Transparent;
            this.groupBox12.Controls.Add(this.lblNitra);
            this.groupBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox12.Location = new System.Drawing.Point(68, 177);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(47, 38);
            this.groupBox12.TabIndex = 76;
            this.groupBox12.TabStop = false;
            // 
            // lblNitra
            // 
            this.lblNitra.AutoSize = true;
            this.lblNitra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNitra.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNitra.Location = new System.Drawing.Point(14, 9);
            this.lblNitra.Name = "lblNitra";
            this.lblNitra.Size = new System.Drawing.Size(36, 28);
            this.lblNitra.TabIndex = 51;
            this.lblNitra.Text = "00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(191, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 23);
            this.label16.TabIndex = 75;
            this.label16.Text = "Nitrogeno en planta";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tbNs
            // 
            this.tbNs.LargeChange = 1;
            this.tbNs.Location = new System.Drawing.Point(9, 244);
            this.tbNs.Maximum = 14;
            this.tbNs.Name = "tbNs";
            this.tbNs.Size = new System.Drawing.Size(167, 45);
            this.tbNs.TabIndex = 72;
            this.tbNs.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbNs.Value = 14;
            this.tbNs.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(12, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 23);
            this.label15.TabIndex = 73;
            this.label15.Text = "Nitrogeno en suelo";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tbPs
            // 
            this.tbPs.LargeChange = 1;
            this.tbPs.Location = new System.Drawing.Point(183, 151);
            this.tbPs.Maximum = 14;
            this.tbPs.Name = "tbPs";
            this.tbPs.Size = new System.Drawing.Size(167, 45);
            this.tbPs.TabIndex = 70;
            this.tbPs.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPs.Value = 14;
            this.tbPs.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(195, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 23);
            this.label12.TabIndex = 71;
            this.label12.Text = "Fosforo en suelo";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.lblFT);
            this.groupBox9.Controls.Add(this.lblDN);
            this.groupBox9.Controls.Add(this.lblNT);
            this.groupBox9.Controls.Add(this.lblDF);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Location = new System.Drawing.Point(6, 15);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(344, 107);
            this.groupBox9.TabIndex = 69;
            this.groupBox9.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 49;
            this.label7.Text = "Dosis de nitrogeno:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(303, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 23);
            this.label11.TabIndex = 68;
            this.label11.Text = "*kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Dosis de fosforo:";
            // 
            // lblFT
            // 
            this.lblFT.AutoSize = true;
            this.lblFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFT.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFT.Location = new System.Drawing.Point(281, 72);
            this.lblFT.Name = "lblFT";
            this.lblFT.Size = new System.Drawing.Size(30, 23);
            this.lblFT.TabIndex = 67;
            this.lblFT.Text = "00";
            this.lblFT.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDN.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDN.Location = new System.Drawing.Point(157, 12);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(30, 23);
            this.lblDN.TabIndex = 61;
            this.lblDN.Text = "00";
            // 
            // lblNT
            // 
            this.lblNT.AutoSize = true;
            this.lblNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNT.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNT.Location = new System.Drawing.Point(298, 49);
            this.lblNT.Name = "lblNT";
            this.lblNT.Size = new System.Drawing.Size(30, 23);
            this.lblNT.TabIndex = 66;
            this.lblNT.Text = "00";
            // 
            // lblDF
            // 
            this.lblDF.AutoSize = true;
            this.lblDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDF.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDF.Location = new System.Drawing.Point(137, 35);
            this.lblDF.Name = "lblDF";
            this.lblDF.Size = new System.Drawing.Size(30, 23);
            this.lblDF.TabIndex = 62;
            this.lblDF.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(173, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 23);
            this.label13.TabIndex = 65;
            this.label13.Text = "Fosforo total:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(173, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 23);
            this.label14.TabIndex = 64;
            this.label14.Text = "Nitrogeno total:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tbNitra
            // 
            this.tbNitra.LargeChange = 1;
            this.tbNitra.Location = new System.Drawing.Point(6, 151);
            this.tbNitra.Maximum = 2;
            this.tbNitra.Minimum = 1;
            this.tbNitra.Name = "tbNitra";
            this.tbNitra.Size = new System.Drawing.Size(167, 45);
            this.tbNitra.TabIndex = 47;
            this.tbNitra.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbNitra.Value = 2;
            this.tbNitra.Scroll += new System.EventHandler(this.tbNi_Scroll);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Location = new System.Drawing.Point(108, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 23);
            this.label20.TabIndex = 59;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nivel de nitrato";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Etapa de fertilizacion:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gray;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.minimizar_signo1;
            this.pictureBox6.Location = new System.Drawing.Point(517, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(551, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tbEtapa
            // 
            this.tbEtapa.LargeChange = 1;
            this.tbEtapa.Location = new System.Drawing.Point(12, 422);
            this.tbEtapa.Maximum = 9;
            this.tbEtapa.Name = "tbEtapa";
            this.tbEtapa.Size = new System.Drawing.Size(569, 45);
            this.tbEtapa.TabIndex = 46;
            this.tbEtapa.Scroll += new System.EventHandler(this.tbEtapa_Scroll);
            // 
            // etapa
            // 
            this.etapa.Tick += new System.EventHandler(this.etapa_Tick);
            // 
            // actualizar
            // 
            this.actualizar.Tick += new System.EventHandler(this.actualizar_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(186, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 39);
            this.label6.TabIndex = 47;
            this.label6.Text = "Selector de etapa";
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(595, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEtapa);
            this.Controls.Add(this.lblFosforo);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siembra";
            this.Load += new System.EventHandler(this.Siembra_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Siembra_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Siembra_MouseUp);
            this.lblFosforo.ResumeLayout(false);
            this.lblFosforo.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPs)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNitra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEtapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox lblFosforo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDF;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TrackBar tbEtapa;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblNDispo;
        private System.Windows.Forms.TrackBar tbNitra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer etapa;
        private System.Windows.Forms.Label lblFT;
        private System.Windows.Forms.Label lblNT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar tbNs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar tbPs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblFDispo;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lblNitra;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txbNp;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label lblNitroS;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label lblFos;
        private System.Windows.Forms.Timer actualizar;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label lblFer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LblFosfo;
        private System.Windows.Forms.Label label6;
    }
}