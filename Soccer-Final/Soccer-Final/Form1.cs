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
                StringBuilder start=new StringBuilder();
                start.AppendLine("Equipo,Jugada,Puntuacion,Tiempo");
                File.AppendAllText(ruta,start.ToString());
                
                
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
            score.Play("GOAL",0,textBox1.Text);
        }

        private void Goal_B_Click(object sender, EventArgs e)
        {
            score.Score(1);
            textBox3.Text = Convert.ToString(score.GetScore(1));
            score.Play("GOAL", 1, textBox1.Text);
        }
        public void DisableAll()
        {
            

               
          
               
            
        }
        public void DisableSTOP()
        {



        }

        public void EnableStart()
        {
           
            
        }

        private void Anotar_A_Click(object sender, EventArgs e)
        {
            score.Play(comboBox1.SelectedItem.ToString(), 0, textBox1.Text);
        }

        private void Anotar_B_Click(object sender, EventArgs e)
        {
            score.Play(comboBox2.SelectedItem.ToString(), 1, textBox1.Text);
        }
    }

    }

