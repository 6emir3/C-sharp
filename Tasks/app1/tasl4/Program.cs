using System;

namespace tasl4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int raz = a - b;
            int pro = a * b;
            Console.WriteLine($"сумма: {sum} разность: {raz} произведение: {pro}");
        }
    }
}
