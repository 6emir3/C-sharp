using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int number = a;
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("while");
            while (number <= b)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }

            number = a;
            Console.WriteLine("do while");
            do
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
            while (number <= b);

            Console.WriteLine("for");
            for(number=a; number <= b; number++)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
