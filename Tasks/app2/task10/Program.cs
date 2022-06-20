using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int n2 = 0;
            int number = 1;
            while (number <= n)
            {
                n2 += number * 2 - 1;
                Console.WriteLine(n2);
                number++;
            }
        }
    }
}
