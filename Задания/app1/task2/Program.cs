using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int chislo = Convert.ToInt32(Console.ReadLine());
            int pr = (chislo / 10 % 10) * (chislo % 10);
            Console.WriteLine(pr);
        }
    }
}
