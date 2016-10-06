using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Final
{
    class RPG_Players
    {
      private  string name;
      private int attack;
      private  int defense;
      private  int goal;

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

        public int Attack
        {
            get
            {
                return attack;
            }

            set
            {
                attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return defense;
            }

            set
            {
                defense = value;
            }
        }

        public int Goal
        {
            get
            {
                return goal;
            }

            set
            {
                goal = value;
            }
        }

        public void NewPlayer(string names,int a,int b,int c)
        {
            name = names;
            attack = a;
            defense = b;
            goal = c;
        }

        
    }
}
