using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Final
{
  public  class FileVerify
    {
        public string rutafinal;

        
        
        public FileInfo Nuevo(string ruta)
        {
            //*
            string dir = Path.GetDirectoryName(ruta);
            string fileName = Path.GetFileNameWithoutExtension(ruta);
            string ext = Path.GetExtension(ruta);
            for (int i = 1; ; ++i)
            {
                if (!File.Exists(ruta))
                {
                    rutafinal = ruta;
                    return new FileInfo(ruta);
                }

                ruta = Path.Combine(dir, fileName + "-" + i + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ext);
            }


        }
    }
}
