using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    { 
        public string thema;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cmdCorona_Click(object sender, EventArgs e)
        {
            grbHauptmenue.Visible = false;
            grbFrage.Visible = true;
            thema = "Corona";
            
        }

        private void cmdFeminismus_Click(object sender, EventArgs e)
        {
            grbHauptmenue.Visible = false;
            grbFrage.Visible = true;
            thema = "Feminismus";
        }

        private void cmdLGBTQ_Click(object sender, EventArgs e)
        {
            grbHauptmenue.Visible = false;
            grbFrage.Visible = true;
            thema = "LBTQ";
        }

        private void cmdAntwortA_Click(object sender, EventArgs e)
        {
            CheckAnswer('A');
        }

        private void cmdAntwortB_Click(object sender, EventArgs e)
        {
            CheckAnswer('B');
        }

        private void cmdAntwortC_Click(object sender, EventArgs e)
        {
            CheckAnswer('C');
        }

        private void cmdAntwortD_Click(object sender, EventArgs e)
        {
            CheckAnswer('D');
        }

        private void tmrZeit_Tick(object sender, EventArgs e)
        {

        }
        public void CheckAnswer(char Antwort)
        {

        }
        public void NaechsteFrage()
        {
            
        }
    }
}
