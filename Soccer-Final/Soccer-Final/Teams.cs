using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Final
{
    class Teams
    {
        int teamsize;
       public Players[] players = new Players[11];
        int goalstot;
        string teamname;
        public Teams(string name)
        {
            teamname = name;
            
            
            stats();
        }

        StringBuilder playerwrite = new StringBuilder();
        public void newplayer(string name)
        {


            if (teamsize <= 11)
            {
                players[teamsize] = new Players(name,teamname,teamsize);
                playerwrite.AppendLine(players[teamsize].tostring());
                teamsize++;
            }
            else
            {
                MessageBox.Show("Esta lleno el equipo");
            }

        }
        public void getplayers()
        {
            int i = 0;
            string[] player = File.ReadAllLines("Stadisticas\\" + teamname + ".csv");
            foreach (string line in player)
            {
                if (i < 11)
                {
                    string[] att = line.Split(',');
                    players[i] = new Players(att[0], teamname, i);


                    i++;
                }
            }


            }
        public void fillplayer()
        {
            int i = 1;
            while (i <= 11)
            {
                newplayer("player" + i.ToString());
                i++;
            }
           
        }
        public void stats()
        {
            Directory.CreateDirectory("Stadisticas");
            if(!File.Exists("Stadisticas\\" + teamname + ".csv"))
            fillplayer();
            File.AppendAllText("Stadisticas\\" + teamname + ".csv", "Nombre,Goals,Pases,Robos,Faltas,GoalTotales,PasesTotales,FaltasTotales,RobosTotales");
            File.AppendAllText("Stadisticas\\" + teamname + ".csv", playerwrite.ToString());
        }
        public void writeplayers()
        {
            
        }
        public List<Players> lista()
        {
            
            List<Players> l = new List<Players>();

            l.AddRange(players);


            return l;

        }
    }
}
