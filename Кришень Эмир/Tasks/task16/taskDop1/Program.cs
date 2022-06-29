using System;
using System.IO;

namespace taskDop1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\taskDop1\\text1.txt";
            File.WriteAllText(file1, "");
       
            Console.Write("Введите числа чрез пробел: ");
            File.AppendAllText(file1, Console.ReadLine());
                

            string readFile1 = File.ReadAllText(file1);
            Console.WriteLine("Файл:\n" + readFile1);

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string[] numbers = readFile1.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.Write($"Числа которые меньше {number}: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) < number)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.Write($"\nПоложительные числа: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) >= 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            double srednee = 0.0;
            int kol = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i+1)%2==0)
                {
                    srednee += Convert.ToDouble(numbers[i]);
                    kol++;
                }
            }
            Console.Write($"\nCреднее арифметическое компонентов файла, стоящих на четных позициях: {srednee/kol}");
        }
    }
}
