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
    public partial class RPG : Form
    {
      
        RPG_Teams[] teams = new RPG_Teams[3];
        RPG_Players play = new RPG_Players();
        RPGAttacks action = new RPGAttacks();
        public RPG()
        {
            InitializeComponent();
            player3.URL = "SuperCampeones.mp3";
            teams[0] = new RPG_Teams("Konoha team");
            teams[1] = new RPG_Teams("El Real Dragon");
            teams[2] = new RPG_Teams("Los Brayans");
            
            teams[0].getplayers();
            comboBox1.DataSource = teams[0].lista();
            comboBox1.DisplayMember = "Name";
            
            teams[1].getplayers();
            comboBox2.DataSource = teams[1].lista();
            comboBox2.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool attack = action.Attack((RPG_Players)comboBox1.SelectedItem, (RPG_Players)comboBox2.SelectedItem);
            if(attack==true)
            {
                MessageBox.Show("Player 1 singa al 2");
            }
            else
            {
                MessageBox.Show("fracaso");
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void RPG_Load(object sender, EventArgs e)
        {
           
        }
    }
}
