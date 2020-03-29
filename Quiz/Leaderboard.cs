using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    class Leaderboard
    {
        FileStream strom;
        string[] leaderboard;

        //Variable zum manuellen sortieren des Leaderboards
        string[,] leaderboardGetrennt;

        /// <summary>
        /// Leaderboardobjekt wird erstellt und alle Plätze aus der dazugehörigen Datei eingelesen
        /// </summary>
        public Leaderboard()
        {
            leaderboard = File.ReadAllLines("Leaderboard.csv", Encoding.Default);
        }

        /// <summary>
        /// Die Platzierung wird in ihren Einzelteilen in einem String zurückgegeben
        /// </summary>
        /// <param name="j">Platzierung-1</param>
        /// <returns>String-Array mit den Details zur Platzierung (Name, Punktzahl, Thema)</returns>
        public string[] GetPlatzierung(int j)
        {
            return leaderboard[j].Split(';');
        }

        /// <summary>
        /// Größe des Leaderboards wird ermittelt
        /// </summary>
        /// <returns>Größe des Leaderboards</returns>
        public int GetLeaderboardGroeße()
        {
            return leaderboard.Length;
        }

        /// <summary>
        /// Leaderboard wird aktualisiert und die Datei um die neue Platzierung aktualisiert
        /// </summary>
        /// <param name="name">Name des Spielers</param>
        /// <param name="punktzahl">Punktzahl des Spielers</param>
        /// <param name="thema">Gespieltes Thema</param>
        public void LeaderboardAktualisieren(string name, int punktzahl, string thema)
        {
            if (leaderboard.Length > 1)
            {
                //Array zur Aufsplittung des Leaderboards in seine Bestandteile wird erstellt
                leaderboardGetrennt = new String[3, leaderboard.Length + 1];

                //Einzelne Bestandteile des Leaderboards werden ins Array geladen
                for (int i = 0; i < leaderboard.Length; i++)
                {
                    string[] value = leaderboard[i].Split(';');
                    leaderboardGetrennt[0, i] = value[0];
                    leaderboardGetrennt[1, i] = value[1];
                    leaderboardGetrennt[2, i] = value[2];
                }

                //Der neue Spieler wird ins Leaderboard geladen
                leaderboardGetrennt[0, leaderboard.Length] = name;
                leaderboardGetrennt[1, leaderboard.Length] = Convert.ToString(punktzahl);
                leaderboardGetrennt[2, leaderboard.Length] = thema;

                //Das Leaderboard wird nach dem Sort-Algorithmus sortiert
                for (int i = leaderboard.Length; i > 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (Convert.ToInt32(leaderboardGetrennt[1, j - 1]) < Convert.ToInt32(leaderboardGetrennt[1, j]))
                        {
                            string temp1 = leaderboardGetrennt[0, j];
                            int temp2 = Convert.ToInt32(leaderboardGetrennt[1, j]);
                            string temp3 = leaderboardGetrennt[2, j];
                            leaderboardGetrennt[0, j] = leaderboardGetrennt[0, j - 1];
                            leaderboardGetrennt[1, j] = leaderboardGetrennt[1, j - 1];
                            leaderboardGetrennt[2, j] = leaderboardGetrennt[2, j - 1];
                            leaderboardGetrennt[0, j - 1] = temp1;
                            leaderboardGetrennt[1, j - 1] = Convert.ToString(temp2);
                            leaderboardGetrennt[2, j - 1] = temp3;
                        }
                    }
                }

                //Ein neues Leaderboard-Array wird gebildet um das aktuelle und sortierte Leaderboard wieder zusammenzufügen
                leaderboard = new string[leaderboardGetrennt.GetUpperBound(1) + 1];

                //Das Leaderboard wird wieder in eine eindimensioales Array zusammengefügt
                for (int i = 0; i < leaderboardGetrennt.GetUpperBound(1) + 1; i++)
                {
                    leaderboard[i] = leaderboardGetrennt[0, i] + ";" + leaderboardGetrennt[1, i] + ";" + leaderboardGetrennt[2, i];
                }

                //Das alte Leaderboard wird gelöscht
                File.Delete("Leaderboard.csv");

                //Das neue Leaderboard wird wieder in die Datei geschrieben
                strom = new FileStream("Leaderboard.csv", FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(strom);
                for (int i = 0; i < leaderboard.Length; i++)
                {
                    schreiben.WriteLine(leaderboard[i]);
                }
                schreiben.Close();
            }

            //Wenn es noch keinen Eintrag im Leaderboard gibt, dann wird das alte gelöscht und ein neues mit dem ersten Eintrag erstellt 
            else
            {
                File.Delete("Leaderboard.csv");
                strom = new FileStream("Leaderboard.csv", FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(strom);

                schreiben.WriteLine(name + ";" + punktzahl + ";" + thema);
                schreiben.Close();
            }
        }
    }
}
