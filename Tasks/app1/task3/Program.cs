using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double z1 = (Math.Sin(2*a) + Math.Sin(5*a) - Math.Sin(3*a)) / (Math.Cos(a) + 1 - 2*(Math.Pow(Math.Sin(2*a),2)) );
            Console.WriteLine("z1: " + z1);
            double z2 = 2 * Math.Sin(a);
            Console.WriteLine("z2: " + z2);
        }
    }
}
