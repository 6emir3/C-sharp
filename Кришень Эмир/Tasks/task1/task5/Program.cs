using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B(оно должно быть больше А): ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a <= b)
            {
                sum += Convert.ToInt32(Math.Pow(a, 2));
                a++;
            }
            Console.Write($"сумму квадратов всех целых чисел от A до B включительно: {sum}");
        }
    }
}
