using System;
using System.Text.RegularExpressions;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Spring, double... Spring? Sprint! This is task regex... This is; task regex... Is this task, regex?";
            Regex sentense = new Regex(@"(\w*\s)*(\w*[;:,-]\s)+(\w*\s)*\w*[.!?]+");
            MatchCollection matches = sentense.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
