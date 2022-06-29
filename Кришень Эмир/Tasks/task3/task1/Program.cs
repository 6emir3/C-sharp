using System;

namespace task1
{
    class Program
    {
        static int Replacement(int a)
        {
            a = a % 10 * 100 + a / 10 % 10 * 10 + a / 100;
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = Replacement(number);
            Console.WriteLine(number);
        }
    }
}
