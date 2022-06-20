using System;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static double Z1(double a)
        {
            return ((Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a)));
        }
        static double Z2(double a)
        {
            return (2 * Math.Sin(a));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Task[] tasks = new Task[2]
            {
                new Task(() => Console.WriteLine("1 задача: "+Z1(a))),
                new Task(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("2 задача: "+Z2(a));
                })
            };
            foreach (var t in tasks)
            {
                t.Start();
                t.Wait();
            }
                

        }
    }
}
