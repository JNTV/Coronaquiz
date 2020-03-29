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
        public string[] Fragekatalog;
        public int frage;


        /// <summary>
        /// Quiz-Objekt wird erstellt
        /// </summary>
        public Quiz ()
        {
            
        }

        /// <summary>
        /// Das Thema des Quizzes wird gesetzt
        /// </summary>
        /// <param name="thema"></param>
        public void SetThema(string thema)
        {
            //Der aktuelle Fragenzähler wird zurückgesetzt (Damit das Quiz bei der ersten Frage anfängt)
            //Und das jeweilige Quiz wird aus der Datei geladen
            this.Thema = (thema);
            switch (thema)
            {
                case "Corona":
                    Fragekatalog = File.ReadAllLines("Corona Quiz.csv", Encoding.Default);
                    break;
                case "Feminismus":
                    Fragekatalog = File.ReadAllLines("Feminismus Quiz.csv", Encoding.Default);
                    break;
                case "LGBTQ":
                    Fragekatalog = File.ReadAllLines("LGBTQ_ Quiz.csv", Encoding.Default);
                    break;
                default:
                    break;
            }
            frage = 1;
        }

        /// <summary>
        /// Die nächste Frage wird geladen
        /// </summary>
        /// <returns>Die nächste Frage, deren Antworten und die richtige Antwort</returns>
        public string[] getNaechsteFrage()
        {
            return Fragekatalog[frage].Split(';');
        }

        /// <summary>
        /// Das aktuell Thema wird übermittelt
        /// </summary>
        /// <returns>Aktuelles Thema</returns>
        public string getThema()
        {
            return Thema;
        }
    }
}
