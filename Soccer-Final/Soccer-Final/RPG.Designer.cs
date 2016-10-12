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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPG));
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
            this.teambbut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.submitbut = new System.Windows.Forms.Button();
            this.PaseA = new System.Windows.Forms.ComboBox();
            this.PaseB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.teambpic = new System.Windows.Forms.PictureBox();
            this.teamapic = new System.Windows.Forms.PictureBox();
            this.soccerfield = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamabut1 = new System.Windows.Forms.Button();
            this.play1 = new System.Windows.Forms.Label();
            this.play2 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teambpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamapic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerfield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.log.Location = new System.Drawing.Point(304, 540);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(439, 72);
            this.log.TabIndex = 3;
            this.log.Text = "";
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
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
            this.teamatxt.BackColor = System.Drawing.Color.Transparent;
            this.teamatxt.Location = new System.Drawing.Point(46, 45);
            this.teamatxt.Name = "teamatxt";
            this.teamatxt.Size = new System.Drawing.Size(37, 13);
            this.teamatxt.TabIndex = 6;
            this.teamatxt.Text = "Team:";
            this.teamatxt.Click += new System.EventHandler(this.teamatxt_Click);
            // 
            // teambtxt
            // 
            this.teambtxt.AutoSize = true;
            this.teambtxt.BackColor = System.Drawing.Color.Transparent;
            this.teambtxt.Location = new System.Drawing.Point(903, 45);
            this.teambtxt.Name = "teambtxt";
            this.teambtxt.Size = new System.Drawing.Size(37, 13);
            this.teambtxt.TabIndex = 8;
            this.teambtxt.Text = "Team:";
            this.teambtxt.Click += new System.EventHandler(this.teambtxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(518, 4);
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
            this.textBox1.Location = new System.Drawing.Point(486, 20);
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
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Location = new System.Drawing.Point(486, 58);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(44, 42);
            this.start.TabIndex = 30;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // teambbut
            // 
            this.teambbut.BackColor = System.Drawing.Color.Transparent;
            this.teambbut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teambbut.BackgroundImage")));
            this.teambbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teambbut.Location = new System.Drawing.Point(921, 327);
            this.teambbut.Name = "teambbut";
            this.teambbut.Size = new System.Drawing.Size(75, 65);
            this.teambbut.TabIndex = 36;
            this.teambbut.UseVisualStyleBackColor = false;
            this.teambbut.Click += new System.EventHandler(this.teambbut_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // submitbut
            // 
            this.submitbut.BackColor = System.Drawing.Color.Transparent;
            this.submitbut.BackgroundImage = global::Soccer_Final.Properties.Resources.fist;
            this.submitbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitbut.ForeColor = System.Drawing.Color.Transparent;
            this.submitbut.Location = new System.Drawing.Point(502, 480);
            this.submitbut.Name = "submitbut";
            this.submitbut.Size = new System.Drawing.Size(58, 54);
            this.submitbut.TabIndex = 37;
            this.submitbut.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(809, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 58);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
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
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
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
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
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
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // teamabut1
            // 
            this.teamabut1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teamabut1.BackgroundImage")));
            this.teamabut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teamabut1.Location = new System.Drawing.Point(47, 327);
            this.teamabut1.Name = "teamabut1";
            this.teamabut1.Size = new System.Drawing.Size(75, 65);
            this.teamabut1.TabIndex = 41;
            this.teamabut1.UseVisualStyleBackColor = true;
            this.teamabut1.Click += new System.EventHandler(this.teamabut1_Click);
            // 
            // play1
            // 
            this.play1.AutoSize = true;
            this.play1.BackColor = System.Drawing.Color.Transparent;
            this.play1.Location = new System.Drawing.Point(200, 86);
            this.play1.Name = "play1";
            this.play1.Size = new System.Drawing.Size(35, 13);
            this.play1.TabIndex = 42;
            this.play1.Text = "label2";
            // 
            // play2
            // 
            this.play2.AutoSize = true;
            this.play2.BackColor = System.Drawing.Color.Transparent;
            this.play2.Location = new System.Drawing.Point(843, 86);
            this.play2.Name = "play2";
            this.play2.Size = new System.Drawing.Size(35, 13);
            this.play2.TabIndex = 43;
            this.play2.Text = "label3";
            // 
            // stop
            // 
            this.stop.BackgroundImage = global::Soccer_Final.Properties.Resources.stop;
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop.Location = new System.Drawing.Point(563, 58);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(40, 42);
            this.stop.TabIndex = 44;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(12, 600);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 31);
            this.button5.TabIndex = 46;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(48, 601);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 30);
            this.button4.TabIndex = 45;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 643);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play2);
            this.Controls.Add(this.play1);
            this.Controls.Add(this.teamabut1);
            this.Controls.Add(this.button1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPG";
            this.Text = "RPG";
            this.Load += new System.EventHandler(this.RPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teambpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamapic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerfield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button teamabut1;
        private System.Windows.Forms.Label play1;
        private System.Windows.Forms.Label play2;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}