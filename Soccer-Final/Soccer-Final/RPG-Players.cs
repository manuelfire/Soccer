using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Final
{
    class RPG_Players
    {
        private string name;
        private int attack;
        private int defense;
        private int goal;
        private bool hasball = false;
        private int passmt;
        private int dribble;
        private int faltas;
        private bool expulsado = false;



        public void getball()
        {
            hasball = true;
        }
        public void loseball()
        {
            hasball = false;
        }
        public bool hasbal()
        {
            return hasball;
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

        public int Passmt
        {
            get
            {
                return passmt;
            }

            set
            {
                passmt = value;
            }
        }

        public int Dribble
        {
            get
            {
                return dribble;
            }

            set
            {
                dribble = value;
            }
        }

        public void NewPlayer(string names, int a, int b, int c, int d, int f)
        {
            name = names;
            attack = a;
            defense = b;
            goal = c;
            Passmt = d;
            Dribble = f;
        }
        public void Expulsar()
        {
            expulsado = true;
        }
        public void falta()
        {
            faltas++;
            if (faltas >= 2)
            {
                expulsado = true;
            }

        }
    }
}
