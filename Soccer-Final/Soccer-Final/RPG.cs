using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Soccer_Final
{
    public partial class RPG : Form
    {
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        RPG_Teams[] teams = new RPG_Teams[2];
        RPG_Players play = new RPG_Players();
        RPGAttacks action = new RPGAttacks();
        List<String> plays = new List<string>();
        List<String> plays2 = new List<string>();
        List<String> Defense = new List<string>();
        List<String> Defense2 = new List<string>();
        List<RPG_Players> PaseALista= new List<RPG_Players>();
        List<RPG_Players> PaseBLista = new List<RPG_Players>();

        DateTime startTime = DateTime.Now;
        StringBuilder textlog = new StringBuilder();
        int turnos = 0;
        TeamScore score = new TeamScore();
        int ballApos = 0;
        int ballBpos = 620;


        String[] F = {"Goal", "Dribble","Pase"};
        String[] d = {"Robo", "Carga","Intercepcion" };
        public RPG()
        {
            string kl;
            InitializeComponent();
            player2.URL = " Resources\\SuperCampeones.mp3";
            timer1.Interval = 1000;
            soccerfield.Controls.Add(teamapic);
            soccerfield.Controls.Add(teambpic);
            teamapic.Location=new Point(ballApos, 0);
            teambpic.Location = new Point(ballBpos, 250);
            textBox1.Text = TimeSpan.FromMinutes(5).ToString();
            plays.AddRange(F);
            plays2.AddRange(F);
            Defense.AddRange(d);
            Defense2.AddRange(d);
            teams[0] = new RPG_Teams("Konoha team");
            teams[1] = new RPG_Teams("El Real Dragon");
            PaseA.Enabled = false;
            PaseB.Enabled = false;
            submitbut.Enabled = false;
            comboBox3.DataSource = plays;
            comboBox4.DataSource = plays2;
            
            teams[0].getplayers();
            comboBox1.DataSource = teams[0].lista();
            comboBox1.DisplayMember = "Name";
            teams[1].getplayers();
            comboBox2.DataSource = teams[1].lista();
            comboBox2.DisplayMember = "Name";
            teamatxt.Text = teamatxt.Text + teams[0].getname();
            teambtxt.Text = teambtxt.Text + teams[1].getname();
            PaseALista = teams[0].lista();
            PaseA.DisplayMember = "Name";
            PaseBLista = teams[1].lista();
            PaseB.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {


            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            teamabut.Enabled = false;
            PaseA.Enabled = false;



        }
        public void saque(int equipo)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            int ran;
            int player = r.Next(0, 10);

           //*
            teams[equipo].players[player].getball();
        }

        private void start_Click(object sender, EventArgs e)
        {

            Random r = new Random((int)DateTime.Now.Ticks);
            int ran;
            int player = r.Next(0, 10);

            if (r.NextDouble() >= 0.5)
            {
                ran = 1;
            }
            else
            {
                ran = 0;
            }
            teams[ran].players[player].getball();
            if (teams[0].teamhasball())
            {

                comboBox3.DataSource = plays;
                comboBox4.DataSource = Defense2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
              int  index = teams[0].playerwithball();
                PaseALista = teams[0].lista();
                PaseALista.RemoveAt(index);
                comboBox1.SelectedIndex = index;
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
            }
            else
            {

                comboBox3.DataSource = Defense;
                comboBox4.DataSource = plays2;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
              int  index = teams[1].playerwithball();
                comboBox2.SelectedIndex = index;
                PaseBLista = teams[1].lista();
                PaseBLista.RemoveAt(index);
                comboBox2.Enabled = false;
                comboBox1.Enabled = true;
            }
            PaseA.DataSource = PaseALista;
            PaseB.DataSource = PaseBLista;
            timer1.Tick += (obj, args) =>
               textBox1.Text =
                   (TimeSpan.FromMinutes(5) - (DateTime.Now - startTime))
                   .ToString("hh\\:mm\\:ss");

            timer1.Enabled = true;
        }
        public void turno()
        {
            
            comboBox3.Enabled = true;
            teamabut.Enabled = true;

            
            comboBox4.Enabled = true;
            teambbut.Enabled = true;
            turnos++;

        }
        public void gotime()
        {
            if (teamabut.Enabled == false && teambbut.Enabled == false)
            {

                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                teamabut.Enabled = false;

                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                teamabut.Enabled = false;
                submitbut.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gotime();
           
        }

        private void teambbut_Click(object sender, EventArgs e)
        {
            

            PaseB.Enabled = false;
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            teambbut.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)//manejo de eventos de los jugadores
        {
            string actionA = comboBox3.Text;
            string actionB = comboBox4.Text;
            RPG_Players player1 = (RPG_Players)comboBox1.SelectedItem;
            RPG_Players player2 = (RPG_Players)comboBox2.SelectedItem;
            RPG_Players paseA= (RPG_Players)PaseA.SelectedItem;
            RPG_Players paseB = (RPG_Players)PaseB.SelectedItem;


            if (actionA == "Goal")
            {
                double goalprob = ballApos / 20;
                if(action.Goal(player1,player2,(RPG_Players)comboBox2.Items[10],goalprob))
                {
                    score.Score(0);
                    scoreA.Text = score.GetScore(0).ToString();
                    textlog.AppendLine("El jugador "+comboBox1.SelectedText+" metio un Gol!!! :"+textBox1.Text);
                    textlog.AppendLine("La puntuacion esta " + teams[0].getname() + ": " + scoreA.Text + " Puntos y " + teams[1].getname() + ": " + scoreB.Text + " Puntos.");
                    log.Text = textlog.ToString();
                    teams[0].players[comboBox1.SelectedIndex].loseball();
                   
                    ballApos = 0;
                    ballBpos = 620;
                    saque(0);

                }
                else
                {
                    textlog.AppendLine("El jugador " + comboBox2.SelectedText + "del equipo " + teams[0].getname() + " FALLO :" + textBox1.Text);
                    log.Text = textlog.ToString();
                    teams[0].players[comboBox1.SelectedIndex].loseball();
                    teams[1].players[comboBox2.SelectedIndex].getball();
                    ballBpos = ballApos;

                }

            }
            else
            {
                if (actionB == "Goal")
                {

                    double goalprob = ballBpos/50;
                    if(ballBpos<100)
                    {
                        goalprob = goalprob * 10;
                    }
                    if (action.Goal(player2,player1, (RPG_Players)comboBox1.Items[10],goalprob))
                    {
                        score.Score(1);
                        scoreB.Text = score.GetScore(1).ToString();
                        textlog.AppendLine("El jugador " + comboBox2.SelectedText + " metio un Gol!!! :" + textBox1.Text);
                        textlog.AppendLine("La puntuacion esta " + teams[0].getname() + ": " + scoreA.Text + " Puntos y " + teams[1].getname() + ": " + scoreB.Text + " Puntos.");
                        log.Text = textlog.ToString();
                        teams[1].players[comboBox2.SelectedIndex].loseball();
                        saque(1);
                        ballApos = 0;
                        ballBpos = 620;


                    }
                    else
                    {
                        textlog.AppendLine("El jugador " + comboBox2.SelectedText + "del equipo " + teams[1].getname() + " FALLO :" + textBox1.Text);
                        log.Text = textlog.ToString();
                        teams[1].players[comboBox2.SelectedIndex].loseball();
                        teams[0].players[comboBox1.SelectedIndex].getball();
                        ballApos = ballBpos;
                    }

                }else
                {
                    if (actionA == "Dribble" && actionB == "Robo")
                    {
                       if(action.Dribleo(player1, player2))
                        {
                            textlog.AppendLine("El jugador " + player1.Name + " del equipo " + teams[0].getname() + " se fue adelante :" + textBox1.Text);
                            ballApos += Convert.ToInt32(teams[0].players[comboBox1.SelectedIndex].Passmt * 1.5);
                            ballBpos = ballApos;
                            

                        }
                        else
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " perdio el balon:" + textBox1.Text);
                            teams[0].players[comboBox1.SelectedIndex].loseball();
                            teams[1].players[comboBox2.SelectedIndex].getball();
                            ballBpos = ballApos;
                        }
                    }
                    if (actionB == "Dribble" && actionA == "Robo")
                    {
                       if( action.Dribleo(player2, player1))
                        {
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[1].getname() + " se fue adelante :" + textBox1.Text);
                            ballBpos -= Convert.ToInt32(teams[1].players[comboBox2.SelectedIndex].Passmt * 1.5);
                            ballApos = ballBpos;
                        }
                        else
                        {
                            textlog.AppendLine("El jugador " + player2.Name + " del equipo " + teams[1].getname() + " perdio el balon:" + textBox1.Text);
                            teams[1].players[comboBox2.SelectedIndex].loseball();
                            teams[0].players[comboBox1.SelectedIndex].getball();
                        }
                    }
                    if (actionA == "Dribble" && actionB == "Carga")
                    {
                       if(action.Carga(player2, player1))
                        {
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[1].getname() + " robo el balon :" + textBox1.Text);
                            log.Text = textlog.ToString();
                            ballApos += Convert.ToInt32(teams[0].players[comboBox1.SelectedIndex].Passmt * 1.5);
                        }
                        else
                        {
                            teams[1].players[comboBox2.SelectedIndex].falta();
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[0].getname() + " acumula 1 falta :" + textBox1.Text);
                            saque(0);
                            ballApos=player1.Passmt*2;
                        }
                    }
                    if (actionB == "Dribble" && actionA == "Carga")
                    {
                        if (action.Carga(player1, player2))
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " robo el balon :" + textBox1.Text);
                            log.Text = textlog.ToString();
                        }
                        else
                        {
                            teams[0].players[comboBox2.SelectedIndex].falta();
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[0].getname() + " acumula 1 falta :" + textBox1.Text);
                            saque(1);
                            ballBpos = 620-(player2.Passmt * 2);
                        }
                    }
                    if (actionA == "Dribble" && actionB == "Intercepcion")
                    {
                        textlog.AppendLine("Que esta haciendo " + player2.Name + "del equipo " + teams[1].getname() + " no entiendo. :" + textBox1.Text);
                        ballApos += Convert.ToInt32(teams[0].players[comboBox1.SelectedIndex].Passmt * 1.5);
                    }
                    if (actionB == "Dribble" && actionA == "Intercepcion")
                    {
                        textlog.AppendLine("Que esta haciendo " + player1.Name + "del equipo " + teams[0].getname() + " no entiendo. :" + textBox1.Text);
                        ballBpos -= Convert.ToInt32(teams[1].players[comboBox2.SelectedIndex].Passmt * 1.5);
                    }
                    if (actionA == "Pase" && actionB == "Intercepcion")
                    {
                      if(action.Pase(player1,player2,paseA))
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " paso el balon a :" + textBox1.Text);
                            teams[0].players[comboBox1.SelectedIndex].loseball();
                            teams[0].players[PaseA.SelectedIndex].getball();
                            ballApos += Convert.ToInt32(teams[0].players[comboBox1.SelectedIndex].Passmt * 1.5);
                        }
                        else
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " perdio el balon :" + textBox1.Text);
                            teams[0].players[comboBox1.SelectedIndex].loseball();
                            teams[1].players[comboBox2.SelectedIndex].getball();
                            ballBpos = ballApos;
                        }
                    }
                    if (actionB == "Pase" && actionA == "Intercepcion")
                    {
                        if (action.Pase(player2, player1, paseB))
                        {
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[1].getname() + " paso el balon a :" + textBox1.Text);
                            teams[1].players[comboBox2.SelectedIndex].loseball();
                            teams[1].players[PaseB.SelectedIndex].getball();
                            ballBpos -= teams[1].players[comboBox2.SelectedIndex].Passmt*2;

                        }
                        else
                        {
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[1].getname() + " perdio el balon :" + textBox1.Text);
                            teams[1].players[comboBox2.SelectedIndex].loseball();
                            teams[0].players[comboBox1.SelectedIndex].getball();
                            ballApos = ballBpos;
                        }
                    }
                }
            }
            comboBox1.DataSource = teams[0].lista();
            comboBox1.DisplayMember = "Name";
            teams[1].getplayers();
            comboBox2.DataSource = teams[1].lista();
            comboBox2.DisplayMember = "Name";
            log.Text = textlog.ToString();
            int index=0;
            teamapic.Location = new Point(ballApos, 0);
            teambpic.Location = new Point(ballBpos, 250);
            if (teams[0].teamhasball())
            {
                
                comboBox3.DataSource = plays;
                comboBox4.DataSource = Defense2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                index = teams[0].playerwithball();
                PaseALista = teams[0].lista();
                PaseALista.RemoveAt(index);
                comboBox1.SelectedIndex = index;
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
            }
            else
            {
                
                comboBox3.DataSource = Defense;
                comboBox4.DataSource = plays2;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                index = teams[1].playerwithball();
                comboBox2.SelectedIndex = index;
                PaseBLista = teams[1].lista();
                PaseBLista.RemoveAt(index);
                comboBox2.Enabled = false;
                comboBox1.Enabled = true;
            }
            turno();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.Text=="Pase")
            {
                PaseA.Enabled = true;
            }
            else
            {
                PaseA.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Pase")
            {
                PaseB.Enabled = true;
            }else
            {
                PaseB.Enabled = false;
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void RPG_Load(object sender, EventArgs e)
        {
            player2.controls.play();
        }

        private void teamatxt_Click(object sender, EventArgs e)
        {
            Form4 klk = new Form4(teams[0].getname());
            klk.Show();

        }
    }
}
