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
    public partial class NewTeam : Form
    {
        RPG_Teams team;
        string[] names = new string[11];
        int index = 0;
        public NewTeam()
        {
            InitializeComponent();
            button4.Enabled = false;
        }

        private void playerViewer1_Load(object sender, EventArgs e)
        {

        }

        private void gen_Click(object sender, EventArgs e)
        {
            names[0] = player1.Text;
            names[1] = player2.Text;
            names[2] = player3.Text;
            names[3] = player4.Text;
            names[4] = player5.Text;
            names[5] = player6.Text;
            names[6] = player7.Text;
            names[7] = player8.Text;
            names[8] = player9.Text;
            names[9] = player10.Text;
            names[10] = player11.Text;
            player1.Enabled = false;
            player2.Enabled = false;
            player3.Enabled = false;
            player4.Enabled = false;
            player5.Enabled = false;
            player6.Enabled = false;
            player7.Enabled = false;
            player8.Enabled = false;
            player9.Enabled = false;
            player10.Enabled = false;
            player11.Enabled = false;

            try
            {
                team = new RPG_Teams(teamname.Text);
            }
            catch(Exception d)
            {
                
            }
            teamname.Enabled = false;
            team.fillplayernames(names);
            team.getplayers();
            button4.Enabled = true;
            gen.Enabled = false;
            settext(0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            team.fillplayernames(names);
            settext(0);
        }
        public void settext(int indexS)
        {
            nameplayer.Text = "Name: " + team.players[indexS].Name;
            attack.Text = "Attack " + team.players[indexS].Attack.ToString();
            defense.Text = "Defense: " + team.players[indexS].Defense.ToString();
            goal.Text = "Goal: " + team.players[indexS].Goal.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
