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
            //Verificamos la diferencia de attaque y defensa entre los jugadores
            Random r= new Random((int)DateTime.Now.Ticks);
            attack = player1.Attack;
            defense = player2.Defense;
            int res = attack - defense;
            if (res < 0)
            {

                if (r.NextDouble() < 0.1)//prob 5%
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
                if (res<=5 && res >= 0)
            {
                
                if(r.NextDouble() <0.25)//prob 25%
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            if (res >5 && res <= 10)
            {
               
                if (r.NextDouble() < 0.50)//prob 50%
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            if (res > 10)
            {
                if (r.NextDouble() < 0.90)//prob 90%
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }
    }
}
