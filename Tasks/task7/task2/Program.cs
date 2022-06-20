using System;
using System.Text.RegularExpressions;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "lold lo lol lol,fghfg- zap zap lol lol lol";
            Regex sentense = new Regex(@"\w+");
            MatchCollection matches = sentense.Matches(s);
            int count = 0;
            string fare = "";
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count-1; i++)
                {
                    if(matches[i].Value == matches[i + 1].Value) 
                    {
                        count++;
                        fare = matches[i].Value;
                    }
                    else
                    {
                        if (count == 1)
                        {
                            Console.WriteLine(fare);
                        }
                        count = 0;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
