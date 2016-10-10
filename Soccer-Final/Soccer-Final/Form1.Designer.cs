namespace Soccer_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaqueA = new System.Windows.Forms.ComboBox();
            this.GoalA = new System.Windows.Forms.ComboBox();
            this.DefensaA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaqueB = new System.Windows.Forms.ComboBox();
            this.GoalB = new System.Windows.Forms.ComboBox();
            this.DefensaB = new System.Windows.Forms.ComboBox();
            this.GoalB_Anotar = new System.Windows.Forms.Button();
            this.DefensaB_Anotar = new System.Windows.Forms.Button();
            this.SaqueB_Anotar = new System.Windows.Forms.Button();
            this.GoalA_Anotar = new System.Windows.Forms.Button();
            this.DefensaA_Anotar = new System.Windows.Forms.Button();
            this.SaqueA_Anotar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(525, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team B";
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.START.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("START.BackgroundImage")));
            this.START.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.START.Location = new System.Drawing.Point(292, 161);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 54);
            this.START.TabIndex = 11;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(262, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(117, 38);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stop
            // 
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.Location = new System.Drawing.Point(292, 221);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 61);
            this.stop.TabIndex = 20;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox2.Location = new System.Drawing.Point(60, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(75, 46);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox3.Location = new System.Drawing.Point(510, 75);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(75, 46);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(299, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tiempo";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.Location = new System.Drawing.Point(100, 332);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(439, 247);
            this.grid.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(82, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Saque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(82, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Defensa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(97, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gol";
            // 
            // SaqueA
            // 
            this.SaqueA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaqueA.FormattingEnabled = true;
            this.SaqueA.Items.AddRange(new object[] {
            "De centro",
            "De banda",
            "De porteria",
            "De esquina"});
            this.SaqueA.Location = new System.Drawing.Point(45, 261);
            this.SaqueA.Name = "SaqueA";
            this.SaqueA.Size = new System.Drawing.Size(121, 21);
            this.SaqueA.TabIndex = 38;
            // 
            // GoalA
            // 
            this.GoalA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalA.FormattingEnabled = true;
            this.GoalA.Items.AddRange(new object[] {
            "Gol normal",
            "Penalti",
            "Autogol",
            "Gol Olimpico",
            "Libre directo"});
            this.GoalA.Location = new System.Drawing.Point(46, 183);
            this.GoalA.Name = "GoalA";
            this.GoalA.Size = new System.Drawing.Size(121, 21);
            this.GoalA.TabIndex = 37;
            // 
            // DefensaA
            // 
            this.DefensaA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefensaA.FormattingEnabled = true;
            this.DefensaA.Items.AddRange(new object[] {
            "Robo de balon",
            "Marcaje",
            "Repliegue",
            "Cobertura",
            "Permuta",
            "Desdoblamiento",
            "Ayudas permanentes",
            "Vigilancia",
            "Temporización",
            "Entrada",
            "Carga",
            "Anticipación",
            "Interceptación",
            "Presión"});
            this.DefensaA.Location = new System.Drawing.Point(45, 221);
            this.DefensaA.Name = "DefensaA";
            this.DefensaA.Size = new System.Drawing.Size(121, 21);
            this.DefensaA.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(527, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Saque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(527, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Defensa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(542, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Gol";
            // 
            // SaqueB
            // 
            this.SaqueB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaqueB.FormattingEnabled = true;
            this.SaqueB.Items.AddRange(new object[] {
            "De centro",
            "De banda",
            "De porteria",
            "De esquina"});
            this.SaqueB.Location = new System.Drawing.Point(490, 261);
            this.SaqueB.Name = "SaqueB";
            this.SaqueB.Size = new System.Drawing.Size(121, 21);
            this.SaqueB.TabIndex = 44;
            // 
            // GoalB
            // 
            this.GoalB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalB.FormattingEnabled = true;
            this.GoalB.Items.AddRange(new object[] {
            "Gol normal",
            "Penalti",
            "Autogol",
            "Gol Olimpico",
            "Libre directo"});
            this.GoalB.Location = new System.Drawing.Point(491, 183);
            this.GoalB.Name = "GoalB";
            this.GoalB.Size = new System.Drawing.Size(121, 21);
            this.GoalB.TabIndex = 43;
            // 
            // DefensaB
            // 
            this.DefensaB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefensaB.FormattingEnabled = true;
            this.DefensaB.Items.AddRange(new object[] {
            "Robo de balon",
            "Marcaje",
            "Repliegue",
            "Cobertura",
            "Permuta",
            "Desdoblamiento",
            "Ayudas permanentes",
            "Vigilancia",
            "Temporización",
            "Entrada",
            "Carga",
            "Anticipación",
            "Interceptación",
            "Presión"});
            this.DefensaB.Location = new System.Drawing.Point(490, 221);
            this.DefensaB.Name = "DefensaB";
            this.DefensaB.Size = new System.Drawing.Size(121, 21);
            this.DefensaB.TabIndex = 42;
            // 
            // GoalB_Anotar
            // 
            this.GoalB_Anotar.Location = new System.Drawing.Point(410, 181);
            this.GoalB_Anotar.Name = "GoalB_Anotar";
            this.GoalB_Anotar.Size = new System.Drawing.Size(75, 23);
            this.GoalB_Anotar.TabIndex = 48;
            this.GoalB_Anotar.Text = "GOLASO";
            this.GoalB_Anotar.UseVisualStyleBackColor = true;
            this.GoalB_Anotar.Click += new System.EventHandler(this.GoalB_Anotar_Click);
            // 
            // DefensaB_Anotar
            // 
            this.DefensaB_Anotar.Location = new System.Drawing.Point(409, 219);
            this.DefensaB_Anotar.Name = "DefensaB_Anotar";
            this.DefensaB_Anotar.Size = new System.Drawing.Size(75, 23);
            this.DefensaB_Anotar.TabIndex = 49;
            this.DefensaB_Anotar.Text = "Anotar";
            this.DefensaB_Anotar.UseVisualStyleBackColor = true;
            this.DefensaB_Anotar.Click += new System.EventHandler(this.DefensaB_Anotar_Click);
            // 
            // SaqueB_Anotar
            // 
            this.SaqueB_Anotar.Location = new System.Drawing.Point(409, 261);
            this.SaqueB_Anotar.Name = "SaqueB_Anotar";
            this.SaqueB_Anotar.Size = new System.Drawing.Size(75, 23);
            this.SaqueB_Anotar.TabIndex = 50;
            this.SaqueB_Anotar.Text = "Anotar";
            this.SaqueB_Anotar.UseVisualStyleBackColor = true;
            this.SaqueB_Anotar.Click += new System.EventHandler(this.SaqueB_Anotar_Click);
            // 
            // GoalA_Anotar
            // 
            this.GoalA_Anotar.Location = new System.Drawing.Point(173, 181);
            this.GoalA_Anotar.Name = "GoalA_Anotar";
            this.GoalA_Anotar.Size = new System.Drawing.Size(75, 23);
            this.GoalA_Anotar.TabIndex = 51;
            this.GoalA_Anotar.Text = "GOLASO";
            this.GoalA_Anotar.UseVisualStyleBackColor = true;
            this.GoalA_Anotar.Click += new System.EventHandler(this.GoalA_Anotar_Click);
            // 
            // DefensaA_Anotar
            // 
            this.DefensaA_Anotar.Location = new System.Drawing.Point(172, 219);
            this.DefensaA_Anotar.Name = "DefensaA_Anotar";
            this.DefensaA_Anotar.Size = new System.Drawing.Size(75, 23);
            this.DefensaA_Anotar.TabIndex = 52;
            this.DefensaA_Anotar.Text = "Anotar";
            this.DefensaA_Anotar.UseVisualStyleBackColor = true;
            this.DefensaA_Anotar.Click += new System.EventHandler(this.DefensaA_Defensa_Click);
            // 
            // SaqueA_Anotar
            // 
            this.SaqueA_Anotar.Location = new System.Drawing.Point(172, 259);
            this.SaqueA_Anotar.Name = "SaqueA_Anotar";
            this.SaqueA_Anotar.Size = new System.Drawing.Size(75, 23);
            this.SaqueA_Anotar.TabIndex = 53;
            this.SaqueA_Anotar.Text = "Anotar";
            this.SaqueA_Anotar.UseVisualStyleBackColor = true;
            this.SaqueA_Anotar.Click += new System.EventHandler(this.SaqueA_Anotar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Grabar_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nosotrosToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            this.nosotrosToolStripMenuItem.Click += new System.EventHandler(this.nosotrosToolStripMenuItem_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged_2);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(572, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 30);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tarjeta Amarilla",
            "Tarjeta Roja"});
            this.comboBox1.Location = new System.Drawing.Point(490, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(525, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Tarjeta";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tarjeta Amarilla",
            "Tarjeta Roja"});
            this.comboBox2.Location = new System.Drawing.Point(45, 300);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(82, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Tarjeta";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(46, 142);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 61;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(490, 143);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(82, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Player";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(527, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 591);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaqueA_Anotar);
            this.Controls.Add(this.DefensaA_Anotar);
            this.Controls.Add(this.GoalA_Anotar);
            this.Controls.Add(this.SaqueB_Anotar);
            this.Controls.Add(this.DefensaB_Anotar);
            this.Controls.Add(this.GoalB_Anotar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaqueB);
            this.Controls.Add(this.GoalB);
            this.Controls.Add(this.DefensaB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaqueA);
            this.Controls.Add(this.GoalA);
            this.Controls.Add(this.DefensaA);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.START);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SaqueA;
        private System.Windows.Forms.ComboBox GoalA;
        private System.Windows.Forms.ComboBox DefensaA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SaqueB;
        private System.Windows.Forms.ComboBox GoalB;
        private System.Windows.Forms.ComboBox DefensaB;
        private System.Windows.Forms.Button GoalB_Anotar;
        private System.Windows.Forms.Button DefensaB_Anotar;
        private System.Windows.Forms.Button SaqueB_Anotar;
        private System.Windows.Forms.Button GoalA_Anotar;
        private System.Windows.Forms.Button DefensaA_Anotar;
        private System.Windows.Forms.Button SaqueA_Anotar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
    }
}

