using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размернось массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[size,size];
            Random rand = new Random();
            Console.Write("Введите число начала диапазона чисел: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число конца диапазона чисел: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            double counter = 0;
            double average = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = rand.Next(a,b+1);
                    if (numbers[i, j] <= m)
                    {
                        counter++;
                        average += numbers[i, j];
                    }
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine("");
            }

            double total = average / counter;
            Console.WriteLine($"среднее арифметическое чисел, небольших заданного M: {total}");

            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    if (numbers[j, i]%2==0)
                    {
                        sum += numbers[j, i];
                    }
                }
                Console.WriteLine($"сумма положительных чисел столбца {i+1}: {sum}"); ;
            }

        }
    }
}
