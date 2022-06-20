using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int c = 8;
            int b = 11;
            double p = (a + b + c * 2) / 2;
            Console.WriteLine(p);
            double s = Math.Pow((p - a) * (p - b) * Math.Pow((p - c),2), 0.5);
            Console.WriteLine(s);
        }
    }
}
