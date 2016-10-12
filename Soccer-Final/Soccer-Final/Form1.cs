using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using WMPLib;



namespace Soccer_Final
{

    public partial class Form1 : Form
        
    {
        WindowsMediaPlayer player3 = new WindowsMediaPlayer();
        DateTime startTime = DateTime.Now;

        Timer timer = new Timer() { Interval = 1000 };
        DateTime tempopaso;
      public TeamScore score = new TeamScore();
        Teams[] teams = new Teams[2];
        string teamatext="team A", teambtext="team B";
        public String ruta;
        bool gamestarted = false;
        DataTable data = new DataTable();
        string title = "Soccer Manager v2.0";
        List<Players> playerAlist = new List<Players>();
        List<Players> playerBlist = new List<Players>();
        private int indexA;
        private int indexB;
        int time = 45;

        public Form1()
        {
            
            InitializeComponent();
           player3.URL = "Resources\\SOCCERCHEER.WAV";
            textBox1.Text = TimeSpan.FromMinutes(time).ToString();
            this.Text = title;

            data.Columns.Add("Equipo");
            data.Columns.Add("Jugador");
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
                teams[0] = new Teams(teamatext);
                teams[1] = new Teams(teambtext);
                playerAlist = teams[0].lista();
                playerBlist = teams[1].lista();
            }
            teamaname.Text = teamatext;
            teambname.Text = teambtext;
            playersA.DataSource = playerAlist;
            playesB.DataSource = playerBlist;
            playersA.DisplayMember = "Name";
            playesB.DisplayMember = "Name";
            settextA(0);
            settextB(0);
            EnableStart();

            timer.Tick += (obj, args) =>
               textBox1.Text =
                   (TimeSpan.FromMinutes(time) - (DateTime.Now - startTime))
                   .ToString("hh\\:mm\\:ss");


            timer.Enabled = true;

            bToolStripMenuItem1.Enabled = false;
            aToolStripMenuItem1.Enabled = false;
           
            
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
            teams[0].players[playersA.SelectedIndex].Goals += 1;
           data.Rows.Add(teamatext,playersA.Text,"GOAL",score.GetScore(0), textBox1.Text);
        }

        private void Goal_B_Click(object sender, EventArgs e)
        {
            score.Score(1);
            teams[1].players[playesB.SelectedIndex].Goals += 1;
            textBox3.Text = Convert.ToString(score.GetScore(1));
            data.Rows.Add(teambtext,playesB.Text, "GOAL", score.GetScore(1), textBox1.Text);
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

     
        

        private void GoalA_Anotar_Click(object sender, EventArgs e)
        {
            score.Score(0);
            textBox2.Text = Convert.ToString(score.GetScore(0));
            teams[0].players[playersA.SelectedIndex].Goals += 1;
            data.Rows.Add(teamatext,playersA.Text,GoalA.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
        }

        private void GoalB_Anotar_Click(object sender, EventArgs e)
        {
            score.Score(1);
            textBox3.Text = Convert.ToString(score.GetScore(1));
            teams[1].players[playesB.SelectedIndex].Goals += 1;
            data.Rows.Add(teambtext,playesB.Text, GoalB.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
        }

        private void DefensaA_Defensa_Click(object sender, EventArgs e)
        {
            String def = DefensaA.SelectedItem.ToString();
            if (def == "Robo de Balon" || def == "Intercepcion" || def == "Carga" || def == "Anticipacion")
            {
                teams[0].players[playersA.SelectedIndex].Robos += 1;
            }
            if (def == "Pase")
            {
                teams[0].players[playersA.SelectedIndex].Pases += 1;
            }
            data.Rows.Add(teamatext,playersA.Text, DefensaA.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
        }

        private void DefensaB_Anotar_Click(object sender, EventArgs e)
        {
            String def = DefensaA.SelectedItem.ToString();
            if (def == "Robo de Balon" || def == "Intercepcion" || def == "Carga" || def == "Anticipacion")
            {
                teams[1].players[playesB.SelectedIndex].Robos += 1;
            }
            if (def == "Pase")
            {
                teams[1].players[playesB.SelectedIndex].Pases += 1;
            }
            data.Rows.Add(teambtext,playesB.Text, DefensaB.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
        }

        private void SaqueA_Anotar_Click(object sender, EventArgs e)
        {
            data.Rows.Add(teamatext,playersA.Text,"Saque de "+ SaqueA.SelectedItem.ToString(), score.GetScore(0), textBox1.Text);
        }

        private void SaqueB_Anotar_Click(object sender, EventArgs e)
        {
            data.Rows.Add(teambtext,playesB.Text,"Saque de " + SaqueB.SelectedItem.ToString(), score.GetScore(1), textBox1.Text);
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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player3.controls.play();
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            indexA++;
            if (indexA <= 10)
            {
                settextA(indexA);

            }
            else
            {
                indexA = 0;
                settextA(indexA);
            }
        }
        public void settextA(int indexS)
        {
            playernameA.Text = "Name: " + teams[0].players[indexS].Name;
            pasesA.Text = "Pases " + teams[0].players[indexS].Pases.ToString();
            faltasA.Text = "Faltas: " + teams[0].players[indexS].Faltas.ToString();
            golAplayer.Text = "Goles: " + teams[0].players[indexS].Goals.ToString();
            robosA.Text="Robos" + teams[0].players[indexS].Robos.ToString();

            pasestotA.Text = "Pases Totales: " + teams[0].players[indexS].Pasestot.ToString();
            faltastotA.Text= "Faltas Totales: " + teams[0].players[indexS].Faltastot.ToString();
            goltotA.Text= "Goles Totales: " + teams[0].players[indexS].Goalstot.ToString();
            robostotA.Text= "Robos Totales" + teams[0].players[indexS].Robostot.ToString();
        }
        public void settextB(int indexS)
        {
            playernameB.Text = "Name: " + teams[1].players[indexS].Name;
            pasesB.Text = "Pases " + teams[1].players[indexS].Pases.ToString();
            faltasB.Text = "Faltas: " + teams[1].players[indexS].Faltas.ToString();
            golBplayer.Text = "Goles: " + teams[1].players[indexS].Goals.ToString();
            robosB.Text = "Robos" + teams[1].players[indexS].Robos.ToString();

            pasestotB.Text = "Pases Totales: " + teams[1].players[indexS].Pasestot.ToString();
            faltastotB.Text = "Faltas Totales: " + teams[1].players[indexS].Faltastot.ToString();
            goltotB.Text = "Goles Totales: " + teams[1].players[indexS].Goalstot.ToString();
            robostotB.Text = "Robos Totales" + teams[1].players[indexS].Robostot.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            indexA--;
            if (indexA >= 0)
            {
                settextA(indexA);

            }
            else
            {
                indexA = 10;
                settextA(indexA);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            indexB++;
            if (indexB <= 10)
            {
                settextB(indexB);

            }
            else
            {
                indexB = 0;
                settextB(indexB);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DefensaA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "00:00:00")
            {
                endgame();
            }
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String titulo = "Ingresar Nombre de Equipo";
            String promptext = "Nuevo Nombre";
            
            string val = Microsoft.VisualBasic.Interaction.InputBox(promptext, titulo, "Default", -1, -1);
            label2.Text = val;
            teamatext = val;
       
            
        }

        private void teamNamesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void bToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String titulo = "Ingresar Nombre de Equipo";
            String promptext = "Nuevo Nombre";
           
            string input = Microsoft.VisualBasic.Interaction.InputBox(promptext,titulo, "Default", -1, -1);

            label3.Text = input;
            teambtext = input;

        }

        private void timeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String titulo = "Ingresar un Nuevo Tiempo";
            String promptext = "Tiempo en Minutos";
            
            string val =Microsoft.VisualBasic.Interaction.InputBox(promptext, titulo, "Default", -1, -1);
            time = Convert.ToInt32(val);
            textBox1.Text = TimeSpan.FromMinutes(time).ToString();

            
        }

        private void playersA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            player3.controls.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player3.controls.pause();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Close();
            player3.controls.stop();
        }
        public void endgame()
        {
            if (score.GetScore(0) > score.GetScore(1))
            {
                MessageBox.Show("Gano el equipo" + teamaname.Text);
                Form2 n = new Form2();
                n.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gano el equipo" + teambname.Text);
                Form2 n = new Form2();
                n.Show();
                this.Close();
            }
        }
    }

    }

