using System;

namespace task55
{
    class Program
    {
        static double Factorial(double n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            double n =Convert.ToInt32(Console.ReadLine());
            double f = (1 + Factorial(n)) / (2 + Factorial(n));
            Console.WriteLine(f);
        }
    }
}
