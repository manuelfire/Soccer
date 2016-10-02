using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Final 
{
   public class WritePlay : FileVerify
    {
        public int teamAs;
        public int teamBs;
       
        public void Play(String jugada,int team, String time)
        {
            String equipo = "";
            
           
            StringBuilder escritor = new StringBuilder();
            
            if (team == 0)
            {
                equipo = "Team A";
                escritor.AppendLine(equipo + "," + jugada + "," + Convert.ToString(teamAs) + "," + time);
            }
            if (team == 1)
            {
                equipo = "Team B";
                escritor.AppendLine(equipo + "," + jugada + "," + Convert.ToString(teamBs)+","+time);
            }
            File.AppendAllText(rutafinal, escritor.ToString());
        }
    }
}
