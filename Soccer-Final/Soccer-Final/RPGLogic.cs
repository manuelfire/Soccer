using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Final
{
    class RPGLogic
    {
        RPGAttacks action = new RPGAttacks();
        TeamScore score = new TeamScore();
        public bool acciones(string actionA,string actionB, RPG_Players player1,RPG_Players player2)
            {
            
            
            if (actionA== "Dribble" && actionB=="Robo")
            {
                return action.Dribleo(player1, player2);
            }
            if (actionB== "Dribble" && actionA=="Robo")
            {
                return action.Dribleo(player2, player1);
            }
            if (actionA == "Dribble" && actionB == "Carga")
            {
                return action.Carga(player2, player1);
            }
            if (actionB == "Dribble" && actionA == "Carga")
            {
                return action.Carga(player2, player1);
            }
            if (actionA == "Dribble" && actionB == "Intercepcion")
            {
                return false;
            }
            if (actionB == "Dribble" && actionA == "Intercepcion")
            {
                return false;
            }
            if (actionA == "Pase" && actionB == "Intercepcion")
            {
                return action.Intercepcion(player2, player1);
            }
            if (actionB == "Pase" && actionA == "Intercepcion")
            {
                return action.Intercepcion(player2, player1);
            }
            return false;
            }
        public bool goal(string actionA, string actionB, RPG_Players player1, RPG_Players player2, RPG_Players player3)
        {
            if (actionA == "Goal")
            {
                if (action.Goal(player1, player2, player3))
                {
                    score.Score(0);
                    return true;


                }
                else
                {
                    return false;
                }
            }
            if (actionB == "Goal")
            {
                if (action.Goal(player2, player1, player3))
                {
                    score.Score(1);
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
