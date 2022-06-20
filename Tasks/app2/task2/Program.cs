using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number / 100) > (number % 10))
            {
                Console.WriteLine("Больше первая");
            }
            else if ((number / 100) < (number % 10))
            {
                Console.WriteLine("Больше последняя");
            }
            else
            {
                Console.WriteLine("Они равны");
            }
        }
    }
}
