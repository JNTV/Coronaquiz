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

        public Leaderboard()
        {
            leaderboard = File.ReadAllLines("Leaderboard.csv");
        }

        public string[] GetPlatzierung(int j)
        {
            return leaderboard[j].Split(';');
        }
        public int GetLeaderboardGroeße()
        {
            return leaderboard.Length;
        }

        public void LeaderboardAktualisieren(string name, int punktzahl, string thema)
        {

            if (leaderboard.Length > 1)
            {
                leaderboardGetrennt = new String[3, leaderboard.Length + 1];

                for (int i = 0; i < leaderboard.Length; i++)
                {
                    string[] value = leaderboard[i].Split(';');
                    leaderboardGetrennt[0, i] = value[0];
                    leaderboardGetrennt[1, i] = value[1];
                    leaderboardGetrennt[2, i] = value[2];
                }

                leaderboardGetrennt[0, leaderboard.Length] = name;
                leaderboardGetrennt[1, leaderboard.Length] = Convert.ToString(punktzahl);
                leaderboardGetrennt[2, leaderboard.Length] = thema;

                for (int i = leaderboard.Length; i > 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (Convert.ToInt32(leaderboardGetrennt[1, j - 1]) > Convert.ToInt32(leaderboardGetrennt[1, j]))
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
                leaderboard = new string[leaderboardGetrennt.GetUpperBound(1) + 1];
                for (int i = 0; i < leaderboardGetrennt.GetUpperBound(1) + 1; i++)
                {
                    leaderboard[i] = leaderboardGetrennt[0, i] + ";" + leaderboardGetrennt[1, i] + ";" + leaderboardGetrennt[2, i];
                }


                File.Delete("Leaderboard.csv");

                strom = new FileStream("Leaderboard.csv", FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(strom);
                for (int i = 0; i < leaderboard.Length; i++)
                {
                    schreiben.WriteLine(leaderboard[i]);
                }
                schreiben.Close();
            }
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
