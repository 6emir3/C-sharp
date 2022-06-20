using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кг конфет: ");
            int candies = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг печенья: ");
            int cookies = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг яблок: ");
            int apples = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите скольок кг конфет вы купили: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скольок кг печенья вы купили: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скольок кг яблок вы купили: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int purchase = candies * x + cookies * y + apples * z;
            Console.WriteLine($"Цена всей покупки: {purchase}");
        }
    }
}
