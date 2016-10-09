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
        int defense2;
        int goal;

        public bool Robo(RPG_Players player1, RPG_Players player2)
        {


            //Verificamos la diferencia de attaque y defensa entre los jugadores
            Random r = new Random((int)DateTime.Now.Ticks);
            attack = player2.Attack;
            defense = player1.Defense;

            double prob = attack / (attack + defense);
            if (r.NextDouble() <= prob)
            {
                return true;

            }

            return false;
        }
        public bool Dribleo(RPG_Players player1, RPG_Players player2)
        {
            //Verificamos la diferencia de attaque y defensa entre los jugadores
            Random r = new Random((int)DateTime.Now.Ticks);
            attack = player1.Attack;
            defense = player2.Attack;
            
            double prob = defense / (attack + defense);
            if (r.NextDouble() <= prob)
            {
                return true;

            }

            return false;
        }
        public bool Goal(RPG_Players player1, RPG_Players player2,RPG_Players arquero)
        {
            //Verificamos la diferencia de attaque y defensa entre los jugadores
            Random r = new Random((int)DateTime.Now.Ticks);
            attack = player1.Goal;
            defense = player2.Defense;
            defense2 = arquero.Defense;
            double prob = attack/(attack+defense+defense2);
            if(r.NextDouble() <= prob)
            {
                return true;
                
            }
           
            return false;
        }
        public bool Intercepcion(RPG_Players player1, RPG_Players player2)
        {
            //Verificamos la diferencia de attaque y defensa entre los jugadores
            Random r = new Random((int)DateTime.Now.Ticks);
            attack = player1.Attack;
            defense = player2.Defense;

            double prob = attack / (attack + defense);
            if (r.NextDouble() <= prob)
            {
                return true;

            }
            return false;
        }
        public bool Pase(RPG_Players player1, RPG_Players player2,RPG_Players player3)
        {
            //Verificamos la diferencia de attaque y defensa entre los jugadores
            Random r = new Random((int)DateTime.Now.Ticks);
            attack = player1.Attack;
            defense = player2.Defense;
            defense2 = player3.Defense;

            double prob = attack+defense2 / (attack + defense+defense2);
            if (r.NextDouble() <= prob)
            {
                return true;

            }
            return false;
        }
        public bool Carga(RPG_Players player1, RPG_Players player2)
        {
            //Verificamos la diferencia de attaque y defensa entre los jugadores
            Random r = new Random((int)DateTime.Now.Ticks);
            attack = player1.Attack+20;
            defense = player2.Attack;

            double prob = attack / (attack + defense);
            if (r.NextDouble() <= prob)
            {
                return true;

            }
            return false;
        }
    }
}
