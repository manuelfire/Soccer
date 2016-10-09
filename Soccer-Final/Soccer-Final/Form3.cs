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
    public partial class Form2 : Form
    {
        RPG_Teams team;
        int index;
        public Form2(string teamname)
        {
            InitializeComponent();
            team = new RPG_Teams(teamname);
            team.getplayers();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            if (index > 10)
            {
                settext(index);
                
            }
            else
            {
                index = 0;
                settext(index);
            }
        }
        public void settext(int index)
        {
            nameplayer.Text += team.players[index].Name;
            attack.Text += team.players[index].Goal.ToString();
            defense.Text += team.players[index].Defense.ToString();
            goal.Text += team.players[index].Goal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            if (index > 0)
            {
                settext(index);
                index--;
            }
            else
            {
                index = 10;
                settext(index);
            }
        }
    }
}
