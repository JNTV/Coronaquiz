using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    class Quiz
    {
        private string Thema { get; set; }
        public string[] Fragekatalog { get; set; }
        public int frage = 0;
        FileStream strom;
        StreamReader lesen;
        public int zaehler = 0; 

        public Quiz ()
        {
            
        }
        public void SetThema(string thema)
        {
            this.Thema = (thema);
            switch (thema)
            {
                case "Corona":
                    strom = new FileStream("Corona Quiz.csv", FileMode.Open, FileAccess.Read);
                    break;
                case "Feminismus":
                    strom = new FileStream("Feminismus Quiz.csv", FileMode.Open, FileAccess.Read);
                    break;
                case "LGBTQ":
                    strom = new FileStream("LGBTQ_ Quiz.csv", FileMode.Open, FileAccess.Read);
                    break;
                default:
                    break;
            }
            lesen = new StreamReader(strom);
            lesen.ReadLine();
            while (lesen.Peek() != -1)
            {
                Fragekatalog[zaehler] = lesen.ReadLine();
                zaehler++;
            }
            lesen.Close();
        }

        public string[] getNaechsteFrage()
        {
            return Fragekatalog[frage].Split(';');
        }
    }
}
