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
        DataTable data = new DataTable();
        string title = "Soccer Manager v1";

        public Form1()
        {
            
            InitializeComponent();
            textBox1.Text = TimeSpan.FromMinutes(45).ToString();
            this.Text = title;
            data.Columns.Add("Equipo");
            data.Columns.Add("Jugada");
            data.Columns.Add("Puntos");
            data.Columns.Add("Tiempo");
            grid.DataSource = data;
            DisableAll();
            
            GoalA.SelectedIndex = 0;
            GoalB.SelectedIndex = 0;
            SaqueA.SelectedIndex = 0;
            SaqueB.SelectedIndex = 0;
            DefensaA.SelectedIndex = 0;
            DefensaB.SelectedIndex = 0;
          openFileDialog1.InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            grid.DataSource = data;
            if (gamestarted == false)
            {
                Directory.CreateDirectory("Juegos");
                FileInfo juegoarch = score.Nuevo("Juegos\\juego.csv");
                ruta = juegoarch.ToString();
                this.Text = title +"-"+ juegoarch.Name.ToString();
                gamestarted = true;
            }
            EnableStart();
            timer.Tick += (obj, args) =>
                textBox1.Text =
                    (TimeSpan.FromMinutes(45) - (DateTime.Now - startTime))
                    .ToString("hh\\:mm\\:ss");

            timer.Enabled = true;
            
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
           data.Rows.Add("Team A","GOAL",score.GetScore(0), textBox1.Text);
        }

        private void Goal_B_Click(object sender, EventArgs e)
        {
            score.Score(1);
            textBox3.Text = Convert.ToString(score.GetScore(1));
            data.Rows.Add("Team B", "GOAL", score.GetScore(1), textBox1.Text);
        }
        public void DisableAll()
        {

            stop.Enabled = false;
            GoalA_Anotar.Enabled = false;
            GoalB_Anotar.Enabled = false;
            DefensaA_Anotar.Enabled = false;
            DefensaB_Anotar.Enabled = false;
            SaqueA_Anotar.Enabled = false;
            SaqueB_Anotar.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
               
          
               
            
        }
        public void DisableSTOP()
        {
            START.Enabled = true;
            stop.Enabled = false;
            GoalA_Anotar.Enabled = false;
            GoalB_Anotar.Enabled = false;
            DefensaA_Anotar.Enabled = false;
            DefensaB_Anotar.Enabled = false;
            SaqueA_Anotar.Enabled = false;
            SaqueB_Anotar.Enabled = false;



        }

        public void EnableStart()
        {
            START.Enabled = false;
            stop.Enabled = true;
            GoalA_Anotar.Enabled = true;
            GoalB_Anotar.Enabled = true;
            DefensaA_Anotar.Enabled = true;
            DefensaB_Anotar.Enabled = true;
            SaqueA_Anotar.Enabled = true;
            SaqueB_Anotar.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            loadToolStripMenuItem.Enabled = false;


        }

        private void Anotar_A_Click(object sender, EventArgs e)
        {
            
            data.Rows.Add("Team A",DefensaA.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
            
        }

        private void Anotar_B_Click(object sender, EventArgs e)
        {
            
            data.Rows.Add("Team B", DefensaA.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
        }
        

        private void GoalA_Anotar_Click(object sender, EventArgs e)
        {
            score.Score(0);
            textBox2.Text = Convert.ToString(score.GetScore(0));
            data.Rows.Add("Team A", GoalA.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
        }

        private void GoalB_Anotar_Click(object sender, EventArgs e)
        {
            score.Score(1);
            textBox3.Text = Convert.ToString(score.GetScore(1));
            data.Rows.Add("Team B", GoalB.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
        }

        private void DefensaA_Defensa_Click(object sender, EventArgs e)
        {
            data.Rows.Add("Team A", DefensaA.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
        }

        private void DefensaB_Anotar_Click(object sender, EventArgs e)
        {
            data.Rows.Add("Team B", DefensaB.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
        }

        private void SaqueA_Anotar_Click(object sender, EventArgs e)
        {
            data.Rows.Add("Team A","Saque de "+ SaqueA.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
        }

        private void SaqueB_Anotar_Click(object sender, EventArgs e)
        {
            data.Rows.Add("Team B", "Saque de " + SaqueB.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
        }

        

        private void Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                score.WrPlay(data, ruta);
                MessageBox.Show("Se ha guardo correctamente");
            }
            catch (IOException c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Cargar un Juego";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                
                    data = score.LoadPlay(file);
                    ruta = file;
                grid.DataSource = data;
                this.Text = title + "-" + openFileDialog1.SafeFileName;

            }
            
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Integrantes:\n Brian Salomon  \n Christopher Curiel   \n Manuel Nuñez  ");
        }
    }

    }

