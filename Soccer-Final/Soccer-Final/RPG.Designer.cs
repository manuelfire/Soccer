namespace Soccer_Final
{
    partial class RPG
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
            this.teamabut = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.teamatxt = new System.Windows.Forms.Label();
            this.teambtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreB = new System.Windows.Forms.TextBox();
            this.scoreA = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.teambpic = new System.Windows.Forms.PictureBox();
            this.teamapic = new System.Windows.Forms.PictureBox();
            this.soccerfield = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teambbut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.submitbut = new System.Windows.Forms.Button();
            this.PaseA = new System.Windows.Forms.ComboBox();
            this.PaseB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teambpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamapic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerfield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // teamabut
            // 
            this.teamabut.Location = new System.Drawing.Point(47, 327);
            this.teamabut.Name = "teamabut";
            this.teamabut.Size = new System.Drawing.Size(75, 23);
            this.teamabut.TabIndex = 0;
            this.teamabut.Text = "Set";
            this.teamabut.UseVisualStyleBackColor = true;
            this.teamabut.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(896, 231);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(299, 525);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(439, 72);
            this.log.TabIndex = 3;
            this.log.Text = "";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(25, 258);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(896, 258);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // teamatxt
            // 
            this.teamatxt.AutoSize = true;
            this.teamatxt.Location = new System.Drawing.Point(46, 45);
            this.teamatxt.Name = "teamatxt";
            this.teamatxt.Size = new System.Drawing.Size(37, 13);
            this.teamatxt.TabIndex = 6;
            this.teamatxt.Text = "Team:";
            // 
            // teambtxt
            // 
            this.teambtxt.AutoSize = true;
            this.teambtxt.Location = new System.Drawing.Point(903, 45);
            this.teambtxt.Name = "teambtxt";
            this.teambtxt.Size = new System.Drawing.Size(37, 13);
            this.teambtxt.TabIndex = 8;
            this.teambtxt.Text = "Team:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(518, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tiempo";
            // 
            // scoreB
            // 
            this.scoreB.BackColor = System.Drawing.SystemColors.InfoText;
            this.scoreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.scoreB.Location = new System.Drawing.Point(906, 65);
            this.scoreB.Multiline = true;
            this.scoreB.Name = "scoreB";
            this.scoreB.ReadOnly = true;
            this.scoreB.Size = new System.Drawing.Size(75, 46);
            this.scoreB.TabIndex = 28;
            this.scoreB.Text = "0";
            this.scoreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scoreA
            // 
            this.scoreA.BackColor = System.Drawing.SystemColors.InfoText;
            this.scoreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.scoreA.Location = new System.Drawing.Point(47, 65);
            this.scoreA.Multiline = true;
            this.scoreA.Name = "scoreA";
            this.scoreA.ReadOnly = true;
            this.scoreA.Size = new System.Drawing.Size(75, 46);
            this.scoreA.TabIndex = 27;
            this.scoreA.Text = "0";
            this.scoreA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(481, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(117, 38);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(502, 77);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 30;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // teambpic
            // 
            this.teambpic.BackColor = System.Drawing.Color.Transparent;
            this.teambpic.Image = global::Soccer_Final.Properties.Resources.iniesta9;
            this.teambpic.Location = new System.Drawing.Point(781, 384);
            this.teambpic.Name = "teambpic";
            this.teambpic.Size = new System.Drawing.Size(63, 56);
            this.teambpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teambpic.TabIndex = 35;
            this.teambpic.TabStop = false;
            // 
            // teamapic
            // 
            this.teamapic.BackColor = System.Drawing.Color.Transparent;
            this.teamapic.Image = global::Soccer_Final.Properties.Resources.Zone_Soccer_Player_Thomas_Müller_3;
            this.teamapic.Location = new System.Drawing.Point(226, 147);
            this.teamapic.Name = "teamapic";
            this.teamapic.Size = new System.Drawing.Size(63, 56);
            this.teamapic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teamapic.TabIndex = 34;
            this.teamapic.TabStop = false;
            // 
            // soccerfield
            // 
            this.soccerfield.Image = global::Soccer_Final.Properties.Resources.soccer_field;
            this.soccerfield.Location = new System.Drawing.Point(194, 106);
            this.soccerfield.Name = "soccerfield";
            this.soccerfield.Size = new System.Drawing.Size(684, 368);
            this.soccerfield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soccerfield.TabIndex = 33;
            this.soccerfield.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Soccer_Final.Properties.Resources.soccer;
            this.pictureBox2.Location = new System.Drawing.Point(906, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Soccer_Final.Properties.Resources.soccer;
            this.pictureBox1.Location = new System.Drawing.Point(35, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // teambbut
            // 
            this.teambbut.Location = new System.Drawing.Point(921, 327);
            this.teambbut.Name = "teambbut";
            this.teambbut.Size = new System.Drawing.Size(75, 23);
            this.teambbut.TabIndex = 36;
            this.teambbut.Text = "Set";
            this.teambbut.UseVisualStyleBackColor = true;
            this.teambbut.Click += new System.EventHandler(this.teambbut_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // submitbut
            // 
            this.submitbut.Location = new System.Drawing.Point(502, 480);
            this.submitbut.Name = "submitbut";
            this.submitbut.Size = new System.Drawing.Size(75, 39);
            this.submitbut.TabIndex = 37;
            this.submitbut.Text = "Go";
            this.submitbut.UseVisualStyleBackColor = true;
            this.submitbut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PaseA
            // 
            this.PaseA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaseA.FormattingEnabled = true;
            this.PaseA.Location = new System.Drawing.Point(25, 286);
            this.PaseA.Name = "PaseA";
            this.PaseA.Size = new System.Drawing.Size(121, 21);
            this.PaseA.TabIndex = 38;
            // 
            // PaseB
            // 
            this.PaseB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaseB.FormattingEnabled = true;
            this.PaseB.Location = new System.Drawing.Point(896, 286);
            this.PaseB.Name = "PaseB";
            this.PaseB.Size = new System.Drawing.Size(121, 21);
            this.PaseB.TabIndex = 39;
            // 
            // RPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 643);
            this.Controls.Add(this.PaseB);
            this.Controls.Add(this.PaseA);
            this.Controls.Add(this.submitbut);
            this.Controls.Add(this.teambbut);
            this.Controls.Add(this.teambpic);
            this.Controls.Add(this.teamapic);
            this.Controls.Add(this.soccerfield);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreB);
            this.Controls.Add(this.scoreA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.teambtxt);
            this.Controls.Add(this.teamatxt);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.log);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.teamabut);
            this.Name = "RPG";
            this.Text = "RPG";
            ((System.ComponentModel.ISupportInitialize)(this.teambpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamapic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerfield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button teamabut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label teamatxt;
        private System.Windows.Forms.Label teambtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scoreB;
        private System.Windows.Forms.TextBox scoreA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox soccerfield;
        private System.Windows.Forms.PictureBox teamapic;
        private System.Windows.Forms.PictureBox teambpic;
        private System.Windows.Forms.Button teambbut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button submitbut;
        private System.Windows.Forms.ComboBox PaseA;
        private System.Windows.Forms.ComboBox PaseB;
    }
}