using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_112_två_textsträngar
{
    class Program
    {
        static void Main(string[] args)
        {
            PutTwoStringsTogether();
        }

        static void PutTwoStringsTogether()
        {
            {
                string firstSentence = "Det var en gång ";
                string secondSentence = "en pojke som skulle gå till skolan";
                string allSentences = firstSentence + " " + secondSentence;
                Console.WriteLine(allSentences);
            }
        }

    }
}
