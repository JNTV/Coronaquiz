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
        StreamReader lesen;
        string[] leaderboard;
        private int i = 0;
        public Leaderboard()
        {
            strom = new FileStream("Leaderboard.csv", FileMode.Open, FileAccess.Read);
            lesen = new StreamReader(strom);
            lesen.ReadLine();
            while (lesen.Peek()!=1)
            {
                leaderboard[i] = lesen.ReadLine();
                i++;
            }
            lesen.Close();
        }
        public string[] GetPlatzierung(int j)
        {
            return leaderboard[j].Split(';');
        }
        public int GetLeaderboardGroeße()
        {
            return leaderboard.Length;
        }
    }
}
