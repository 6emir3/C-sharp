using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            int cheslo = Convert.ToInt32(Console.ReadLine()); ;
            int newCheslo = cheslo / 1000 * 100 + cheslo / 100 % 10 * 1000 + cheslo / 10 % 10 + cheslo % 10 * 10;
            Console.WriteLine(newCheslo);
        }
    }
}
