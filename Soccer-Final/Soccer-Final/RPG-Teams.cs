using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Soccer_Final
{
    class RPG_Teams
    {
        string teamname;
        RPG_Players[] players = new RPG_Players[11];
        int teamsize = 0;
        Random rand = new Random((int)DateTime.Now.Ticks);
        
        StringBuilder playertext=new StringBuilder();
        public RPG_Teams(string teamname)
        {
            this.teamname = teamname;
            Directory.CreateDirectory("Equipos");
            if (!File.Exists("Equipos\\" + teamname + ".csv"))
            {
                File.Create("Equipos\\" + teamname + ".csv").Dispose();
            }
            
        }
        public void newplayer(string name)
        {
            

            if (teamsize < 11)
            {
                int attack = rand.Next(50, 100);
                int defense = rand.Next(50, 100);
                int goal = rand.Next(50, 100);

                
                playertext.AppendLine(name+","+attack.ToString()+","+defense.ToString()+","+goal.ToString());
                teamsize++;
            }
            else
            {
                MessageBox.Show("Esta lleno el equipo");
            }
            
        }
        public void wrpl()
        {
            File.WriteAllText("Equipos\\" + teamname + ".csv", playertext.ToString());
        }
        public void fillplayer()
        {
            int i = 1;
            while(i<=11)
            {
                newplayer("player" + i);
                i++;
            }
            wrpl();
        }
        public void getplayers()
        {
            int i = 0;
            string[] player = File.ReadAllLines("Equipos\\" + teamname + ".csv");
            foreach(string line in player)
            {
                if (i < 11)
                {
                    string[] att = line.Split(',');
                    players[i] = new RPG_Players();
                    players[i].NewPlayer(att[0], Convert.ToInt16(att[1]), Convert.ToInt16(att[2]), Convert.ToInt16(att[3]));
                    i++;
                }
                


            }

        }
        public List<RPG_Players> lista ()
            {
            List<RPG_Players> l = new List<RPG_Players>();

            l.AddRange(players);
            

            return l;

            }
        
       

    }
}
