using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y=0;
            if ( (1<=x) && (x<=5))
            {
                y = Math.Log10(x) + Math.Pow(Math.Cos(Math.Pow(x, 2)), 2);
            }
            else if (x == Math.PI)
            {
                y = Math.Pow(Math.Sin(x), 2);
            }
            Console.WriteLine($"y: {y}");
        }
    }
}
