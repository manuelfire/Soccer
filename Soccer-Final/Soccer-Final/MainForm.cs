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

namespace Soccer_Final
{
    public partial class MainForm : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Form1 f = new Form1();
        RPG r = new RPG();
        public MainForm()
        {
            InitializeComponent();
            player.URL = "Waka-Waka.mp3";
            
            r.MdiParent = this;
            f.MdiParent = this;
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            player.controls.play();
            
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.Show();
        }

        private void rPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
