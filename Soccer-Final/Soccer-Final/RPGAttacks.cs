using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Final
{
    class RPGAttacks
    {
        int attack;
        int defense;
        int goal;

        public bool Attack(RPG_Players player1, RPG_Players player2)
        {
            attack = player1.Attack;
            defense = player1.Defense;
            goal = player1.Goal;
            return false;
        }
    }
}
