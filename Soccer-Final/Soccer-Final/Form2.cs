using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
//lklkl
namespace Soccer_Final
{
    public partial class Form2 : Form
    {
        WindowsMediaPlayer player4 = new WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
            player4.URL = "Resources\\Waka-Waka.mp3";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
            player4.controls.stop();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeamChooser newForm = new TeamChooser();
            newForm.Show();
            this.Hide();
            player4.controls.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player4.controls.stop();
            Application.Exit();


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            player4.controls.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player4.controls.pause();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player4.controls.play();
        }
    }
}
