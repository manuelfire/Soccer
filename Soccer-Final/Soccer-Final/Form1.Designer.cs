﻿namespace Soccer_Final
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
            this.Goal_A = new System.Windows.Forms.Button();
            this.Anotar_A = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.Anotar_B = new System.Windows.Forms.Button();
            this.Goal_B = new System.Windows.Forms.Button();
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
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
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
            // Goal_A
            // 
            this.Goal_A.Location = new System.Drawing.Point(60, 259);
            this.Goal_A.Name = "Goal_A";
            this.Goal_A.Size = new System.Drawing.Size(75, 23);
            this.Goal_A.TabIndex = 3;
            this.Goal_A.Text = "Goal";
            this.Goal_A.UseVisualStyleBackColor = true;
            this.Goal_A.Click += new System.EventHandler(this.Goal_A_Click);
            // 
            // Anotar_A
            // 
            this.Anotar_A.AllowDrop = true;
            this.Anotar_A.Location = new System.Drawing.Point(60, 218);
            this.Anotar_A.Name = "Anotar_A";
            this.Anotar_A.Size = new System.Drawing.Size(75, 23);
            this.Anotar_A.TabIndex = 5;
            this.Anotar_A.Text = "Anotar";
            this.Anotar_A.UseVisualStyleBackColor = true;
            this.Anotar_A.Click += new System.EventHandler(this.Anotar_A_Click);
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
            // Anotar_B
            // 
            this.Anotar_B.Location = new System.Drawing.Point(510, 218);
            this.Anotar_B.Name = "Anotar_B";
            this.Anotar_B.Size = new System.Drawing.Size(75, 23);
            this.Anotar_B.TabIndex = 13;
            this.Anotar_B.Text = "Anotar";
            this.Anotar_B.UseVisualStyleBackColor = true;
            this.Anotar_B.Click += new System.EventHandler(this.Anotar_B_Click);
            // 
            // Goal_B
            // 
            this.Goal_B.Location = new System.Drawing.Point(510, 259);
            this.Goal_B.Name = "Goal_B";
            this.Goal_B.Size = new System.Drawing.Size(75, 23);
            this.Goal_B.TabIndex = 12;
            this.Goal_B.Text = "Goal";
            this.Goal_B.UseVisualStyleBackColor = true;
            this.Goal_B.Click += new System.EventHandler(this.Goal_B_Click);
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
            this.grid.Location = new System.Drawing.Point(37, 285);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(586, 247);
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
            this.Grabar.Location = new System.Drawing.Point(528, 539);
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
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "De centro",
            "De banda",
            "De porteria",
            "De esquina"});
            this.comboBox5.Location = new System.Drawing.Point(36, 186);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 38;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Gol normal",
            "Penalti",
            "Autogol",
            "Gol Olimpico",
            "Libre directo"});
            this.comboBox3.Location = new System.Drawing.Point(37, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(36, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "De centro",
            "De banda",
            "De porteria",
            "De esquina"});
            this.comboBox2.Location = new System.Drawing.Point(481, 186);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 44;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Gol normal",
            "Penalti",
            "Autogol",
            "Gol Olimpico",
            "Libre directo"});
            this.comboBox4.Location = new System.Drawing.Point(482, 108);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 43;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
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
            this.comboBox6.Location = new System.Drawing.Point(481, 146);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Grabar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Anotar_B);
            this.Controls.Add(this.Goal_B);
            this.Controls.Add(this.START);
            this.Controls.Add(this.Anotar_A);
            this.Controls.Add(this.Goal_A);
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
        private System.Windows.Forms.Button Goal_A;
        private System.Windows.Forms.Button Anotar_A;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button Anotar_B;
        private System.Windows.Forms.Button Goal_B;
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
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}

