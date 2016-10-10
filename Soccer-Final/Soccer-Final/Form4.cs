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
    public partial class Form4 : Form
    {
        RPG_Teams team;
        int index;
        public Form4(string teamname)
        {
            InitializeComponent();
            team = new RPG_Teams(teamname);
            team.getplayers();
            settext(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            if (index <= 10)
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
            nameplayer.Text ="Name: "+team.players[index].Name;
            attack.Text = "Attack " + team.players[index].Attack.ToString();
            defense.Text = "Defense: " + team.players[index].Defense.ToString();
            goal.Text = "Goal: " + team.players[index].Goal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            if (index >= 0)
            {
                settext(index);
                
            }
            else
            {
                index = 10;
                settext(index);
            }
        }
    }
}
