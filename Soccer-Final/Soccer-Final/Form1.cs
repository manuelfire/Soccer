using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Soccer_Final
{
    public partial class Form1 : Form
    {
        DateTime startTime = DateTime.Now;

        Timer timer = new Timer() { Interval = 1000 };
       
      public TeamScore score = new TeamScore();
        
        public String ruta;
        bool gamestarted = false;

        public Form1()
        {
            InitializeComponent();
            
            textBox1.Text = TimeSpan.FromMinutes(45).ToString();
            
            DisableAll();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gamestarted == false)
            {
                Directory.CreateDirectory("Juegos");
                FileInfo juegoarch = score.Nuevo("Juegos\\juego.csv");
                ruta = juegoarch.ToString();
                gamestarted = true;
            }
            EnableStart();
            timer.Tick += (obj, args) =>
                textBox1.Text =
                    (TimeSpan.FromMinutes(45) - (DateTime.Now - startTime))
                    .ToString("hh\\:mm\\:ss");

            timer.Enabled = true;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            DisableSTOP();
            timer.Enabled = false;
            
        }

        private void Goal_A_Click(object sender, EventArgs e)
        {
            score.Score(0);
            textBox2.Text = Convert.ToString(score.GetScore(0)); 
            grid.Rows.Add("Team A","GOAL",score.GetScore(0), textBox1.Text);
        }

        private void Goal_B_Click(object sender, EventArgs e)
        {
            score.Score(1);
            textBox3.Text = Convert.ToString(score.GetScore(1));
            grid.Rows.Add("Team B", "GOAL", score.GetScore(1), textBox1.Text);
        }
        public void DisableAll()
        {

            stop.Enabled = false;
            Anotar_A.Enabled = false;
            Anotar_B.Enabled = false;
            Goal_A.Enabled = false;
            Goal_B.Enabled = false;
               
          
               
            
        }
        public void DisableSTOP()
        {
            START.Enabled = true;
            stop.Enabled = false;
            Anotar_A.Enabled = false;
            Goal_A.Enabled = false;
            Goal_B.Enabled = false;


        }

        public void EnableStart()
        {
            START.Enabled = false;
            stop.Enabled = true;
            Anotar_A.Enabled = true;
            Goal_A.Enabled = true;
            Goal_B.Enabled = true;

        }

        private void Anotar_A_Click(object sender, EventArgs e)
        {
            
            grid.Rows.Add("Team A",comboBox1.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
            
        }

        private void Anotar_B_Click(object sender, EventArgs e)
        {
            
            grid.Rows.Add("Team B", comboBox1.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
        }
        public void OnExportGridToCSV(object sender, System.EventArgs e)
        {
            // Create the CSV file to which grid data will be exported.
            StreamWriter sw = new StreamWriter(ruta, false);
            // First we will write the headers.
            DataTable dt = ((DataSet)grid.DataSource).Tables[0];

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
            // Now write all the rows.
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
    }

    }

