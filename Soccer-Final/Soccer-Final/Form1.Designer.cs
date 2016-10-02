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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grabar = new System.Windows.Forms.Button();
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
            this.Cargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team B";
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(283, 106);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 11;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(262, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(117, 46);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(283, 146);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 20;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(60, 42);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 46);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(510, 42);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 46);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tiempo";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equipo,
            this.Jugada,
            this.Puntos,
            this.Tiempo});
            this.grid.Location = new System.Drawing.Point(117, 285);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(439, 247);
            this.grid.TabIndex = 26;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            // 
            // Jugada
            // 
            this.Jugada.HeaderText = "Jugada";
            this.Jugada.Name = "Jugada";
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // Grabar
            // 
            this.Grabar.Location = new System.Drawing.Point(481, 538);
            this.Grabar.Name = "Grabar";
            this.Grabar.Size = new System.Drawing.Size(75, 23);
            this.Grabar.TabIndex = 27;
            this.Grabar.Text = "Save";
            this.Grabar.UseVisualStyleBackColor = true;
            this.Grabar.Click += new System.EventHandler(this.OnExportGridToCSV);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Saque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Defensa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gol";
            // 
            // SaqueA
            // 
            this.SaqueA.FormattingEnabled = true;
            this.SaqueA.Items.AddRange(new object[] {
            "De centro",
            "De banda",
            "De porteria",
            "De esquina"});
            this.SaqueA.Location = new System.Drawing.Point(36, 186);
            this.SaqueA.Name = "SaqueA";
            this.SaqueA.Size = new System.Drawing.Size(121, 21);
            this.SaqueA.TabIndex = 38;
            // 
            // GoalA
            // 
            this.GoalA.FormattingEnabled = true;
            this.GoalA.Items.AddRange(new object[] {
            "Gol normal",
            "Penalti",
            "Autogol",
            "Gol Olimpico",
            "Libre directo"});
            this.GoalA.Location = new System.Drawing.Point(37, 108);
            this.GoalA.Name = "GoalA";
            this.GoalA.Size = new System.Drawing.Size(121, 21);
            this.GoalA.TabIndex = 37;
            this.GoalA.SelectedIndexChanged += new System.EventHandler(this.GoalA_SelectedIndexChanged);
            // 
            // DefensaA
            // 
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
            this.DefensaA.Location = new System.Drawing.Point(36, 146);
            this.DefensaA.Name = "DefensaA";
            this.DefensaA.Size = new System.Drawing.Size(121, 21);
            this.DefensaA.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Saque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Defensa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Gol";
            // 
            // SaqueB
            // 
            this.SaqueB.FormattingEnabled = true;
            this.SaqueB.Items.AddRange(new object[] {
            "De centro",
            "De banda",
            "De porteria",
            "De esquina"});
            this.SaqueB.Location = new System.Drawing.Point(481, 186);
            this.SaqueB.Name = "SaqueB";
            this.SaqueB.Size = new System.Drawing.Size(121, 21);
            this.SaqueB.TabIndex = 44;
            // 
            // GoalB
            // 
            this.GoalB.FormattingEnabled = true;
            this.GoalB.Items.AddRange(new object[] {
            "Gol normal",
            "Penalti",
            "Autogol",
            "Gol Olimpico",
            "Libre directo"});
            this.GoalB.Location = new System.Drawing.Point(482, 108);
            this.GoalB.Name = "GoalB";
            this.GoalB.Size = new System.Drawing.Size(121, 21);
            this.GoalB.TabIndex = 43;
            // 
            // DefensaB
            // 
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
            this.DefensaB.Location = new System.Drawing.Point(481, 146);
            this.DefensaB.Name = "DefensaB";
            this.DefensaB.Size = new System.Drawing.Size(121, 21);
            this.DefensaB.TabIndex = 42;
            // 
            // GoalB_Anotar
            // 
            this.GoalB_Anotar.Location = new System.Drawing.Point(401, 106);
            this.GoalB_Anotar.Name = "GoalB_Anotar";
            this.GoalB_Anotar.Size = new System.Drawing.Size(75, 23);
            this.GoalB_Anotar.TabIndex = 48;
            this.GoalB_Anotar.Text = "GOLASO";
            this.GoalB_Anotar.UseVisualStyleBackColor = true;
            this.GoalB_Anotar.Click += new System.EventHandler(this.GoalB_Anotar_Click);
            // 
            // DefensaB_Anotar
            // 
            this.DefensaB_Anotar.Location = new System.Drawing.Point(400, 144);
            this.DefensaB_Anotar.Name = "DefensaB_Anotar";
            this.DefensaB_Anotar.Size = new System.Drawing.Size(75, 23);
            this.DefensaB_Anotar.TabIndex = 49;
            this.DefensaB_Anotar.Text = "Anotar";
            this.DefensaB_Anotar.UseVisualStyleBackColor = true;
            this.DefensaB_Anotar.Click += new System.EventHandler(this.DefensaB_Anotar_Click);
            // 
            // SaqueB_Anotar
            // 
            this.SaqueB_Anotar.Location = new System.Drawing.Point(400, 186);
            this.SaqueB_Anotar.Name = "SaqueB_Anotar";
            this.SaqueB_Anotar.Size = new System.Drawing.Size(75, 23);
            this.SaqueB_Anotar.TabIndex = 50;
            this.SaqueB_Anotar.Text = "Anotar";
            this.SaqueB_Anotar.UseVisualStyleBackColor = true;
            this.SaqueB_Anotar.Click += new System.EventHandler(this.SaqueB_Anotar_Click);
            // 
            // GoalA_Anotar
            // 
            this.GoalA_Anotar.Location = new System.Drawing.Point(164, 106);
            this.GoalA_Anotar.Name = "GoalA_Anotar";
            this.GoalA_Anotar.Size = new System.Drawing.Size(75, 23);
            this.GoalA_Anotar.TabIndex = 51;
            this.GoalA_Anotar.Text = "GOLASO";
            this.GoalA_Anotar.UseVisualStyleBackColor = true;
            this.GoalA_Anotar.Click += new System.EventHandler(this.GoalA_Anotar_Click);
            // 
            // DefensaA_Anotar
            // 
            this.DefensaA_Anotar.Location = new System.Drawing.Point(163, 144);
            this.DefensaA_Anotar.Name = "DefensaA_Anotar";
            this.DefensaA_Anotar.Size = new System.Drawing.Size(75, 23);
            this.DefensaA_Anotar.TabIndex = 52;
            this.DefensaA_Anotar.Text = "Anotar";
            this.DefensaA_Anotar.UseVisualStyleBackColor = true;
            this.DefensaA_Anotar.Click += new System.EventHandler(this.DefensaA_Defensa_Click);
            // 
            // SaqueA_Anotar
            // 
            this.SaqueA_Anotar.Location = new System.Drawing.Point(163, 184);
            this.SaqueA_Anotar.Name = "SaqueA_Anotar";
            this.SaqueA_Anotar.Size = new System.Drawing.Size(75, 23);
            this.SaqueA_Anotar.TabIndex = 53;
            this.SaqueA_Anotar.Text = "Anotar";
            this.SaqueA_Anotar.UseVisualStyleBackColor = true;
            this.SaqueA_Anotar.Click += new System.EventHandler(this.SaqueA_Anotar_Click);
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(117, 538);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(75, 23);
            this.Cargar.TabIndex = 54;
            this.Cargar.Text = "Load";
            this.Cargar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 573);
            this.Controls.Add(this.Cargar);
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
            this.Controls.Add(this.Grabar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.START);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.Button Grabar;
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
        private System.Windows.Forms.Button Cargar;
    }
}

