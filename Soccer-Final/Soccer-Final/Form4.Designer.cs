namespace Soccer_Final
{
    partial class Form4
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
            this.nameplayer = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.Label();
            this.defense = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameplayer
            // 
            this.nameplayer.AutoSize = true;
            this.nameplayer.Location = new System.Drawing.Point(13, 172);
            this.nameplayer.Name = "nameplayer";
            this.nameplayer.Size = new System.Drawing.Size(41, 13);
            this.nameplayer.TabIndex = 1;
            this.nameplayer.Text = "Name: ";
            // 
            // attack
            // 
            this.attack.AutoSize = true;
            this.attack.Location = new System.Drawing.Point(13, 200);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(44, 13);
            this.attack.TabIndex = 2;
            this.attack.Text = "Attack: ";
            // 
            // defense
            // 
            this.defense.AutoSize = true;
            this.defense.Location = new System.Drawing.Point(13, 228);
            this.defense.Name = "defense";
            this.defense.Size = new System.Drawing.Size(53, 13);
            this.defense.TabIndex = 3;
            this.defense.Text = "Defense: ";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(13, 257);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(35, 13);
            this.goal.TabIndex = 4;
            this.goal.Text = "Goal: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.defense);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.nameplayer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameplayer;
        private System.Windows.Forms.Label attack;
        private System.Windows.Forms.Label defense;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}