using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Final
{
    public partial class MainForm : Form
    {
        Form1 f = new Form1();
        RPG r = new RPG();
        public MainForm()
        {
            InitializeComponent();
            
            r.MdiParent = this;
            f.MdiParent = this;
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.Show();
        }

        private void rPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r.Show();
        }
    }
}
