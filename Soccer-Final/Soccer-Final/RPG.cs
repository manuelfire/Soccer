using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Final
{
    public partial class RPG : Form
    {
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
        int bolapos = 0;


        String[] F = {"Goal", "Dribble","Pase"};
        String[] d = {"Robo", "Carga","Intercepcion" };
        public RPG()
        {
            
            InitializeComponent();
            timer1.Interval = 1000;
            soccerfield.Controls.Add(teamapic);
            soccerfield.Controls.Add(teambpic);
            teamapic.Location=new Point(0, 0);
            teambpic.Location = new Point(450, 200);
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


            turnoB();
            
           

        }

        private void start_Click(object sender, EventArgs e)
        {
            
            Random r = new Random((int)DateTime.Now.Ticks);
            int ran;
            int player = r.Next(0, 10);
            
            if (r.NextDouble() >= 0.5)
            {
                ran = 1;
            }else
            {
                ran = 0;
            }
            teams[ran].players[player].getball();
            if (teams[0].teamhasball())
            {
                comboBox1.SelectedIndex = player;
                comboBox3.DataSource = plays;
                comboBox4.DataSource = Defense2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                PaseALista.RemoveAt(player);
            }
            else
            {
                comboBox2.SelectedIndex = player;
                comboBox3.DataSource = Defense;
                comboBox4.DataSource = plays2;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                PaseBLista.RemoveAt(player);
            }
            PaseA.DataSource = PaseALista;
            PaseB.DataSource = PaseBLista;
            timer1.Tick += (obj, args) =>
               textBox1.Text =
                   (TimeSpan.FromMinutes(5) - (DateTime.Now - startTime))
                   .ToString("hh\\:mm\\:ss");

            timer1.Enabled = true;
        }
        public void turnoA()
        {
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            teamabut.Enabled = true;

            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            teambbut.Enabled = false;

        }
        public void turnoB()
        {
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            teamabut.Enabled = true;

            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            teamabut.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void teambbut_Click(object sender, EventArgs e)
        {
            submitbut.Enabled = true;
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            teamabut.Enabled = false;

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
                if(action.Goal(player1,player2,(RPG_Players)comboBox2.Items[10]))
                {
                    score.Score(0);
                    scoreA.Text = score.GetScore(0).ToString();
                    textlog.AppendLine("El jugador "+comboBox1.SelectedText+" metio un Gol!!! :"+textBox1.Text);
                    textlog.AppendLine("La puntuacion esta " + teams[0].getname() + ": " + scoreA.Text + " Puntos y " + teams[1].getname() + ": " + scoreB.Text + " Puntos.");
                    log.Text = textlog.ToString();
                    

                }
                else
                {
                    textlog.AppendLine("El jugador " + comboBox2.SelectedText + "del equipo " + teams[0].getname() + " FALLO :" + textBox1.Text);
                    log.Text = textlog.ToString();
                }

            }
            else
            {
                if (actionB == "Goal")
                {
                    if (action.Goal(player2,player1, (RPG_Players)comboBox1.Items[10]))
                    {
                        score.Score(1);
                        scoreB.Text = score.GetScore(1).ToString();
                        textlog.AppendLine("El jugador " + comboBox2.SelectedText + " metio un Gol!!! :" + textBox1.Text);
                        textlog.AppendLine("La puntuacion esta " + teams[0].getname() + ": " + scoreA.Text + " Puntos y " + teams[1].getname() + ": " + scoreB.Text + " Puntos.");
                        log.Text = textlog.ToString();


                    }
                    else
                    {
                        textlog.AppendLine("El jugador " + comboBox2.SelectedText + "del equipo " + teams[1].getname() + " FALLO :" + textBox1.Text);
                        log.Text = textlog.ToString();
                    }

                }else
                {
                    if (actionA == "Dribble" && actionB == "Robo")
                    {
                       if(action.Dribleo(player1, player2))
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " se fue adelante :" + textBox1.Text);
                            
                        }
                        else
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " perdio el balon:" + textBox1.Text);
                            teams[0].players[comboBox1.SelectedIndex].loseball();
                            teams[1].players[comboBox2.SelectedIndex].hasbal();
                        }
                    }
                    if (actionB == "Dribble" && actionA == "Robo")
                    {
                       if( action.Dribleo(player2, player1))
                        {
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[1].getname() + " se fue adelante :" + textBox1.Text);
                            log.Text = textlog.ToString();
                        }else
                        {
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[1].getname() + " perdio el balon:" + textBox1.Text);
                            teams[1].players[comboBox2.SelectedIndex].loseball();
                            teams[0].players[comboBox1.SelectedIndex].hasbal();
                        }
                    }
                    if (actionA == "Dribble" && actionB == "Carga")
                    {
                       if(action.Carga(player2, player1))
                        {
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[0].getname() + " robo el balon :" + textBox1.Text);
                            log.Text = textlog.ToString();
                        }
                        else
                        {
                            teams[1].players[comboBox2.SelectedIndex].falta();
                            textlog.AppendLine("El jugador " + player2.Name + "del equipo " + teams[0].getname() + " acumula 1 falta :" + textBox1.Text);
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
                        }
                    }
                    if (actionA == "Dribble" && actionB == "Intercepcion")
                    {
                        textlog.AppendLine("Que esta haciendo " + player2.Name + "del equipo " + teams[1].getname() + " no entiendo. :" + textBox1.Text);
                    }
                    if (actionB == "Dribble" && actionA == "Intercepcion")
                    {
                        textlog.AppendLine("Que esta haciendo " + player1.Name + "del equipo " + teams[0].getname() + " no entiendo. :" + textBox1.Text);
                    }
                    if (actionA == "Pase" && actionB == "Intercepcion")
                    {
                      if(action.Pase(player1,player2,paseA))
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " paso el balon a :" + textBox1.Text);
                            teams[0].players[comboBox1.SelectedIndex].loseball();
                            teams[0].players[PaseA.SelectedIndex].hasbal();

                        }
                        else
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[0].getname() + " perdio el balon :" + textBox1.Text);
                            teams[0].players[comboBox1.SelectedIndex].loseball();
                            teams[1].players[comboBox2.SelectedIndex].hasbal();
                        }
                    }
                    if (actionB == "Pase" && actionA == "Intercepcion")
                    {
                        if (action.Pase(player2, player1, paseB))
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[1].getname() + " paso el balon a :" + textBox1.Text);
                            teams[1].players[comboBox2.SelectedIndex].loseball();
                            teams[1].players[PaseB.SelectedIndex].hasbal();

                        }
                        else
                        {
                            textlog.AppendLine("El jugador " + player1.Name + "del equipo " + teams[1].getname() + " perdio el balon :" + textBox1.Text);
                            teams[1].players[comboBox2.SelectedIndex].loseball();
                            teams[0].players[comboBox1.SelectedIndex].hasbal();
                        }
                    }
                }
            }
            log.Text = textlog.ToString();
            int index;
            if (teams[0].teamhasball())
            {
                index = teams[0].playerwithball();
            }
            else
            {
                index = teams[1].playerwithball();
            }
            if (teams[0].teamhasball())
            {
                
                comboBox3.DataSource = plays;
                comboBox4.DataSource = Defense2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                
                comboBox3.DataSource = Defense;
                comboBox4.DataSource = plays2;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
           

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
    }
}
