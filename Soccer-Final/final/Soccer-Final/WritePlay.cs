using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Final 
{
   public class WritePlay : FileVerify
    {
        
       
        public void WrPlay(DataTable dt,String ruta)
        {
            // Crear el CSV.
            StreamWriter sw = new StreamWriter(ruta, false);
            // Importar DataGrid A DataTable.
            
           

            int iColCount = dt.Columns.Count;
            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            // Escribir Celdas.
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        sw.Write(dr[i].ToString());
                    }
                    if (i < iColCount - 1)
                    {
                        sw.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public DataTable LoadPlay(String ruta)
        {
            DataGridView loader = new DataGridView();
            
            String[] lines=File.ReadAllLines(ruta);
            String[] data_col = null;
            DataTable dt = new DataTable();
            int counter= 0;
            foreach (string text in lines)
            {
                data_col = text.Split(',');
                if(counter==0)
                {
                    for(int i=0;i<=data_col.Count()-1;i++)
                    {
                        dt.Columns.Add(data_col[i]);
                    }
                    counter++;
                }else
                {
                    dt.Rows.Add(data_col);

                }
            }


            return dt;
        }
    }
}
