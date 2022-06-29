using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размернось массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Random rand = new Random();
            bool truth = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-4,5);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");
            for (int i = 1; i < numbers.Length; i++)
            {
                if ((numbers[i]%2==0) && (numbers[i-1] % 2 != 0))
                {
                    truth = true;
                }
                else if ((numbers[i] % 2 == 0) && (numbers[i - 1] % 2 == 0))
                {
                    truth = false;
                    break;
                }

            }

            if (truth==true)
            {
                for (int i = numbers.Length-1; i >= 0; i--)
                {
                    if (numbers[i] >= 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = numbers.Length-1; i >= 0; i--)
                {
                    if (numbers[i] < 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }
}
