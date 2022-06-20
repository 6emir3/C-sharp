using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[12,4];
            Random rand = new Random();
            int max3 = 0;
            int max4 = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = rand.Next(1,6);
                    Console.Write($"{i+1} {j+1} : {numbers[i, j]}   ");
                }
                Console.WriteLine("");
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[2, j] > max3)
                {
                    max3 = numbers[2, j];
                }
                if (numbers[3, j] > max4)
                {
                    max4 = numbers[3, j];
                }
            }
            Console.WriteLine($"самая большая семья 3 этажа: {max3} человек");
            Console.WriteLine($"самая большая семья 4 этажа: {max4} человек");
        }
    }
}
