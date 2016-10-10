using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Soccer_Final
{
    class RPG_Teams
    {//*
        string teamname;
      public  RPG_Players[] players = new RPG_Players[11];
        int teamsize = 0;
        
        Random rand = new Random((int)DateTime.Now.Ticks);
        private RNGCryptoServiceProvider Rand =
    new RNGCryptoServiceProvider();
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
        public string getname()
        {
            return teamname;
        }
        public void newplayer(string name)
        {
           

            if (teamsize < 11)
            {
                int attack = RandomInteger(50,100);
                
                int defense = RandomInteger(50, 100);
                int goal = RandomInteger(50, 100);
                int pass = RandomInteger(10, 50);
                int dribble = RandomInteger(10, 30);

                
                playertext.AppendLine(name+","+attack.ToString()+","+defense.ToString()+","+goal.ToString() + "," +pass.ToString()+","+dribble.ToString());
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
        public void fillplayernames(string[] names)
        {
            int counter = 0;
            foreach(string n in names)
            {
                if (counter < 11)
                {
                    newplayer(n);
                }
                counter++;
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
                    players[i].NewPlayer(att[0], Convert.ToInt16(att[1]), Convert.ToInt16(att[2]), Convert.ToInt16(att[3]),Convert.ToInt16(att[4]),Convert.ToInt32(att[5]));
                    i++;
                }
                


            }

        }
        public List<RPG_Players> lista ()
            {
            int index = 0;
            List<RPG_Players> l = new List<RPG_Players>();
            
            l.AddRange(players);
            

            return l;

            }
        public bool teamhasball()
        {
            foreach(RPG_Players p in players)
            {
                if(p.hasbal())
                {
                    return true;
                }
            }
            return false;
        }
        public int playerwithball()
        {
            int counter = 0;
            foreach (RPG_Players p in players)
            {
                if (p.hasbal())
                {
                    return counter;
                }
                counter++;
            }

            return 0;
        }
        public void playersout()
        {

        }
        private int RandomInteger(int min, int max)
        {
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                
                byte[] four_bytes = new byte[4];
                Rand.GetBytes(four_bytes);

                
                scale = BitConverter.ToUInt32(four_bytes, 0);
            }

            
            int seed= (int)(min + (max - min) *
                (scale / (double)uint.MaxValue));
            Random rand2 = new Random(seed);
            return rand2.Next(min, max);
        }


    }
}
