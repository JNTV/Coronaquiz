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
        private string spielername;
        private string[] aktuelleFrage;
        public string thema;
        private Quiz aktuelleRunde = new Quiz();
        private int SpielerPunktzahl { get; set; }
        private int zeit = 2000;
        private Leaderboard aktuellesLeaderboard;
        private ListViewItem[] leaderboard = new ListViewItem[3];
        public Form1()
        {
            InitializeComponent();
            SpielerPunktzahl = 0;
            AenderungenImplementieren();

        }

        //Das Thema Corona wird ausgewählt
        private void cmdCorona_Click(object sender, EventArgs e)
        {
            //Das Hauptmenü verschwindet und das Spielfeld erscheint
            grbHauptmenue.Visible = false;
            grbFrage.Visible = true;

            //Das Thema der aktuellen Runde wird auf Corona gesetzt
            aktuelleRunde.SetThema ("Corona");

            //Die erste Frage wird aufgedeckt
            NaechsteFrage();
        }

        //Das Thema Feminismus wird ausgewählt
        private void cmdFeminismus_Click(object sender, EventArgs e)
        {
            //Das Hauptmenü verschwindet und das Spielfeld erscheint
            grbHauptmenue.Visible = false;
            grbFrage.Visible = true;

            //Das Thema der aktuellen Runde wird auf Feminismus gesetzt
            aktuelleRunde.SetThema("Feminismus");

            //Die erste Frage wird aufgedeckt
            NaechsteFrage();
        }

        //Das Thema LGBTQ* wird ausgewählt
        private void cmdLGBTQ_Click(object sender, EventArgs e)
        {
            //Das Hauptmenü verschwindet und das Spielfeld erscheint
            grbHauptmenue.Visible = false;
            grbFrage.Visible = true;

            //Das Thema der aktuellen Runde wird auf LGBTQ* gesetzt
            aktuelleRunde.SetThema("LGBTQ");
            
            //Die erste Frage wird aufgedeckt
            NaechsteFrage();
        }

        //Antwort A wird ausgewählt
        private void cmdAntwortA_Click(object sender, EventArgs e)
        {
            //Antwort A wird auf Richtigkeit überprüft 
            CheckAnswer('A');
        }

        //Antwort B wird ausgewählt
        private void cmdAntwortB_Click(object sender, EventArgs e)
        {
            //Antwort B wird auf Richtigkeit überprüft
            CheckAnswer('B');
        }

        //Antwort C wird ausgewählt
        private void cmdAntwortC_Click(object sender, EventArgs e)
        {
            //Antwort C wird auf Richtigkeit überprüft
            CheckAnswer('C');
        }

        //Antwort D wird ausgewählt
        private void cmdAntwortD_Click(object sender, EventArgs e)
        {
            //Antwort D wird auf Richtigkeit überprüft
            CheckAnswer('D');
        }

        //Der Timer zählt jede Milisekunde runter
        private void tmrZeit_Tick(object sender, EventArgs e)
        {
            zeit--;

            //Progressbar geht zurück
            prgZeit.Value--;

            //Zeitanzeige wird aktualisiert
            lblZeit.Text = ("Noch " + (zeit / 100) + " Sekunden");

            //Zeitablauf wird überprüft
            if (zeit==0)
            {
                tmrZeit.Enabled = false;
                //Alertfenster wird geöffnet und Nutzer wird darauf aufmerksam gemacht, dass die Zeit zu Ende ist
                MessageBox.Show("Leider zu langsam ;)" + Environment.NewLine + "Die Richtige Antwort war:" + Environment.NewLine + aktuelleFrage[5]);

                //Nächste Frage wird aufgedeckt
                NaechsteFrage();
            }
        }

        /// <summary>
        /// Richtigkeit der Antwort wird überprüft
        /// </summary>
        /// <param name="antwort">abgegebene Antwort</param>
        public void CheckAnswer(char antwort)
        {
            tmrZeit.Enabled = false;
            //Die richtige Antwort wird mit der abgegebenen 
            if (antwort == Convert.ToChar(aktuelleFrage[5]))
            {
                //Antwort war richtig und Spieler bekommt 10 Punkte
                MessageBox.Show("Richtige Antwort!");
                SpielerPunktzahl += 10;
            }
            else if (Convert.ToChar(aktuelleFrage[5]) == 'A')
            {
                MessageBox.Show("Leider die falsche Antwort!" + Environment.NewLine + "Die richtige Antwort war: " + Environment.NewLine + cmdAntwortA.Text);
            }
            else if (Convert.ToChar(aktuelleFrage[5]) == 'B')
            {
                MessageBox.Show("Leider die falsche Antwort!" + Environment.NewLine + "Die richtige Antwort war: " + Environment.NewLine + cmdAntwortB.Text);
            }
            else if (Convert.ToChar(aktuelleFrage[5]) == 'C')
            {
                MessageBox.Show("Leider die falsche Antwort!" + Environment.NewLine + "Die richtige Antwort war: " + Environment.NewLine + cmdAntwortC.Text);
            }
            else if (Convert.ToChar(aktuelleFrage[5]) == 'D')
            {
                MessageBox.Show("Leider die falsche Antwort!" + Environment.NewLine + "Die richtige Antwort war: " + Environment.NewLine + cmdAntwortD.Text);
            }
            else if (Convert.ToChar(aktuelleFrage[5]) == 'E')
            {
                MessageBox.Show("Alle Antworten sind richtig!!!!");
                SpielerPunktzahl += 10;
            }

            //Nächste Frage wird aufgedeckt
            NaechsteFrage();
        }

        /// <summary>
        /// Nächste Frage wird aufgedeckt
        /// </summary>
        public void NaechsteFrage()
        {
            //Es wird geprüft, ob noch eine Frage vorhanden ist
            if (aktuelleRunde.Fragekatalog.Length >aktuelleRunde.frage)
            {
                //Zeit wird wieder auf 20 Sekunden gestellt
                //
                //Die aktuelle Frage wird in das Array gesetzt
                //
                //Die aktuelle Frage wird in das Label lblFrage geschrieben
                //
                //Die Antworten werden in die jeweiligen Buttons geschrieben
                //
                //
                zeit = 2000;
                prgZeit.Value = 2000;
                aktuelleFrage = aktuelleRunde.getNaechsteFrage();
                lblFrage.Text = aktuelleFrage[0];
                cmdAntwortA.Text = aktuelleFrage[1];
                cmdAntwortB.Text = aktuelleFrage[2];
                cmdAntwortC.Text = aktuelleFrage[3];
                cmdAntwortD.Text = aktuelleFrage[4];
                aktuelleRunde.frage++;
                tmrZeit.Enabled = true;
            }
            else
            {
                //Runde wird beendet
                BeendeRunde();
            }
            
        }

        /// <summary>
        /// Leaderboard wird erstellt und die ersten 3 Plätze ins ListView-Object geladen
        /// </summary>
        public void AenderungenImplementieren()
        {
            aktuellesLeaderboard = new Leaderboard();
            if (aktuellesLeaderboard.GetLeaderboardGroeße() < 3)
            {
                for (int i = 0; i < aktuellesLeaderboard.GetLeaderboardGroeße(); i++)
                {
                    //string[] platzierung = aktuellesLeaderboard.GetPlatzierung(i);
                    //leaderboard[i] = new ListViewItem(Convert.ToString(i + 1));
                    //leaderboard[i].SubItems.Add(platzierung[0]);
                    //leaderboard[i].SubItems.Add(platzierung[1]);
                    //leaderboard[i].SubItems.Add(platzierung[2]);
                }                
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    //Leaderboarditems werden erstellt und zum Leaderboard hinzugefügt
                    string[] platzierung = aktuellesLeaderboard.GetPlatzierung(i);
                    leaderboard[i] = new ListViewItem(Convert.ToString(i + 1));
                    leaderboard[i].SubItems.Add(platzierung[0]);
                    leaderboard[i].SubItems.Add(platzierung[1]);
                    leaderboard[i].SubItems.Add(platzierung[2]);
                    this.lvwLeaderboard.Items.Add(leaderboard[i]);
                }
            }
        }

        /// <summary>
        /// Runde wird beendet und Programm zurückgesetzt
        /// </summary>
        public void BeendeRunde()
        {
            MessageBox.Show("Das Spiel ist vorbei. Du hast " + SpielerPunktzahl + " Punkte gemacht!");
            ShowMyDialogBox();

            //Leaderboard wird aktualisiert
            Leaderboardaktualisieren();
            grbHauptmenue.Visible = true;
            grbFrage.Visible = false;
            SpielerPunktzahl = 0;
        }

        /// <summary>
        /// Leaderboard wird aktualisiert
        /// </summary>
        public void Leaderboardaktualisieren()
        {
            aktuellesLeaderboard.LeaderboardAktualisieren(spielername, SpielerPunktzahl,aktuelleRunde.getThema());
            AenderungenImplementieren();
        }

        /// <summary>
        /// Spielername wird abgefragt
        /// </summary>
        public void ShowMyDialogBox()
        {
            frmName testDialog = new frmName();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.spielername = testDialog.txtResult.Text;
            }
            else
            {
                this.spielername = "";
            }
            testDialog.Dispose();
        }

        //Spiel wird neugestartet. Der Spieler sieht wieder das Hauptmenü
        private void cmdNeu_Click(object sender, EventArgs e)
        {
            grbHauptmenue.Visible = true;
            grbFrage.Visible = false;
            SpielerPunktzahl = 0;
        }
    }
}
