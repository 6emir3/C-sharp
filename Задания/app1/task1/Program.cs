using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вес в фунтах: ");
            double funt = Convert.ToInt32(Console.ReadLine());
            double kg = funt * 0.4095;
            Console.Write("Вес в кг: "+kg);
        }
    }
}
