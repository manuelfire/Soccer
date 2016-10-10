using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Final
{
    public partial class TeamChooser : Form
    {
        List<String> listaA = new List<string>();
        List<String> listaB= new List<string>();
        public TeamChooser()
        {
            InitializeComponent();
        }

        private void addteam_Click(object sender, EventArgs e)
        {
            NewTeam n =new NewTeam();
            n.Show();
        }

        private void TeamChooser_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Equipos");
            foreach (string s in Directory.GetFiles("Equipos", "*.csv").Select(Path.GetFileNameWithoutExtension))
            {
                listaA.Add(s);
                listaB.Add(s);

            }
            comboBox1.DataSource = listaA;
            comboBox2.DataSource = listaB;
               

        }

        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                RPG newForm = new RPG(comboBox1.Text, comboBox2.Text, textBox1.Text, textBox2.Text);
                newForm.Show();
                this.Close();
            }
            catch(Exception s)
            {
                MessageBox.Show(s.ToString());
            }
           
        }
    }
}
