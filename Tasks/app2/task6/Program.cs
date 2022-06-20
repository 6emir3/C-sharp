using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //a = Math.PI / 6;
            //b = 2 * Math.PI / 3;
            //m = 10;
            Console.Write("Введите А: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B(оно должно быть больше А): ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите M: ");
            double m = Convert.ToInt32(Console.ReadLine());
            double h = (b - a) / Convert.ToDouble(m);
            Console.WriteLine("Шаг {0:f2}",h);
            while (a <= b)
            {
                Console.WriteLine("{0:f2}",Math.Sin(Math.Pow(a, 2)));
                a += h;
            }
        }
    }
}
