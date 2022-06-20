using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number < 100)
            {
                if( Math.Pow(number/10,2) + Math.Pow(number % 10, 2) == 13)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
