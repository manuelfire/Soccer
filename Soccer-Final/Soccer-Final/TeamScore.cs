using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Soccer_Final
{
    
   public class TeamScore : WritePlay
    {
        int teamA;
        int teamB;
       

        public void Score(int team)
        {
            if(team==0)
            {
                teamA++;
              
              
            }
            if (team == 1)
            {
                teamB++;
                
            }
        }
        public int GetScore(int team)
        {
            if (team == 0)
            {
               return teamA;


            }
            if (team == 1)
            {
               return teamB;
            }
            return 0;
        }
    }
}
