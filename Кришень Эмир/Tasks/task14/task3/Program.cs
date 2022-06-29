using System;
using System.Threading;

namespace task3
{
    class Program
    {
        static void Plus()
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }
            Console.WriteLine(sum);
        }

        static void Multiplication()
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= Math.Pow(a, i);
            }
            Console.WriteLine(sum);
        }
        
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Plus));
            Thread thread2 = new Thread(new ThreadStart(Plus));
            thread1.Start();
            thread2.Start();
            Multiplication();
        }
    }
}
