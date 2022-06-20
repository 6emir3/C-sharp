using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размернось массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Random rand = new Random();

            Console.WriteLine("Старый массив");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(30);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\nНовый массив");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] = 0;
                }
                Console.Write(numbers[i] + " ");
            }





        }
    }
}
