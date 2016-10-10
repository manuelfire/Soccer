using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Final
{
    class Players
    {
        string name;
        int numbershirt;
        int pases;
        int goals;
        int robos;
        int faltas;
        int pasestot;
        int goalstot;
        int faltastot;
        int robostot;
        string teamname;
        public Players(string names,string team,int number)
        {
            Name = names;
            teamname = team;
            numbershirt = number;
            
        }
        public void updateplayer()
        {
            string write = tostring();
            string[] lines = File.ReadAllLines("Stadisticas\\" + teamname + ".csv");
            int counter = 0;
            lines[numbershirt] = write;
            File.WriteAllLines("Stadisticas\\" + teamname + ".csv",lines);


        }
        public string tostring()
        {
            String play=name+","+Pases.ToString()+","+Goals.ToString()+","+Faltas.ToString()+","+Robos.ToString()+","+Pasestot.ToString()+","+Goalstot.ToString()+","+Faltastot.ToString()+","+Robostot.ToString();

            return play;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Pases
        {
            get
            {
                return pases;
            }

            set
            {
                if(Pasestot!=0)
                { Pasestot = Pasestot - Pases; }
                
                pases = value;
                Pasestot = Pasestot + Pases;
                updateplayer();

            }
        }

        public int Goals
        {
            get
            {
                return goals;
            }

            set
            {
                if(Goalstot!=0)
                { Goalstot = Goalstot - Goals; }
                goals = value;
                Goalstot = Goalstot + Goals;
                updateplayer();
            }
        }

        public int Robos
        {
            get
            {
                return robos;
            }

            set
            {
                robos = value;
                updateplayer();
            }
        }

        public int Faltas
        {
            get
            {
                return faltas;
            }

            set
            {
                faltas = value;
                updateplayer();
            }
        }

        public int Pasestot
        {
            get
            {
                return pasestot;
            }

            set
            {
                pasestot = value;
            }
        }

        public int Goalstot
        {
            get
            {
                return goalstot;
            }

            set
            {
                goalstot = value;
            }
        }

        public int Faltastot
        {
            get
            {
                return faltastot;
            }

            set
            {
                faltastot = value;
            }
        }

        public int Robostot
        {
            get
            {
                return robostot;
            }

            set
            {
                robostot = value;
            }
        }
    }
}
