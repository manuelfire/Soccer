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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.Goal_A.Location = new System.Drawing.Point(60, 232);
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
            this.Anotar_A.Location = new System.Drawing.Point(60, 191);
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
            this.Anotar_B.Location = new System.Drawing.Point(510, 191);
            this.Anotar_B.Name = "Anotar_B";
            this.Anotar_B.Size = new System.Drawing.Size(75, 23);
            this.Anotar_B.TabIndex = 13;
            this.Anotar_B.Text = "Anotar";
            this.Anotar_B.UseVisualStyleBackColor = true;
            this.Anotar_B.Click += new System.EventHandler(this.Anotar_B_Click);
            // 
            // Goal_B
            // 
            this.Goal_B.Location = new System.Drawing.Point(510, 232);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BOLA",
            "ROBO",
            "SAQUE",
            "PENAL"});
            this.comboBox1.Location = new System.Drawing.Point(37, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "BOLA",
            "ROBO",
            "SAQUE",
            "PENAL"});
            this.comboBox2.Location = new System.Drawing.Point(488, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 356);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

