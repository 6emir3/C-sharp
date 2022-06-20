using System;

namespace task1_2_
{
    class Program
    {
        static double f(double x)
        {
            double y = 0;
            if ((x == 1) || (x == -1))
            {
                y = 1;
            }
            else if ((x >= 0) && (x != 1))
            {
                y = 1.0 / (1 - x);
            }
            else
            {
                y = 1.0 / (1 + x);
            }
            return y;
        }

        static void f(double x, out double y)
        {
            y = 0;
            if ((x == 1) || (x == -1))
            {
                y = 1;
            }
            else if ((x >= 0) && (x != 1))
            {
                y = 1.0 / (1 - x);
            }
            else
            {
                y = 1.0 / (1 + x);
            }

        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());

            for (int x = a; x <= b; x += h)
            {
                Console.WriteLine(f(x));
            }
            double y = 0;
            for (int x = a; x <= b; x += h)
            {
                f(x, out y);
                Console.WriteLine(y);
            }
        }
    }
}
