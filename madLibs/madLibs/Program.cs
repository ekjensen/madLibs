using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = "Sir [author] who wrote the book [book name] is from [city]. ";

            int run = 0;
            string FinishedTemplate = "";

            while (run != -1)
            {
                int startBracket = template.IndexOf("[");
                run = startBracket;
                int endBracket = template.IndexOf("]");
                int length = endBracket - startBracket + 1;

                if (run > -1)
                {
                    //replaces the bracketed words with user input
                    string sub = template.Substring(startBracket, length);
                    Console.WriteLine(sub);
                    Console.WriteLine("Enter the name of a " + sub);
                    sub = Console.ReadLine();

                    int startPos = 0;
                    string BeforeBracket = template.Substring(startPos, startBracket);
                    string afterBracket = template.Substring(endBracket + 1, template.Length - endBracket - 1);
                    FinishedTemplate = BeforeBracket + sub + afterBracket;
                    template = FinishedTemplate;
                }
                else
                {
                }
            }
            Console.WriteLine(template);
            Console.ReadLine();
        }
    }
}
