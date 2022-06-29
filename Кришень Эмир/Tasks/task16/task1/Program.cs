using System;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string file1 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\task1\\f.txt";
            string file2 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\task1\\g.txt";
            File.WriteAllText(file1, "");
            File.WriteAllText(file2, "");

            Console.Write("Введите количество чисел для файла f: ");
            int kol = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kol; i++)
            { 
                File.AppendAllText(file1, Convert.ToString(rnd.Next(100)) + " ");
            }

            string readFile1 = File.ReadAllText(file1);
            Console.WriteLine($"Числа в файле f: {readFile1}");
            string[] numbers = readFile1.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            int number;
            for (int i = 0; i < numbers.Length; i++)
            { 
                number = Convert.ToInt32(numbers[i]);
                if ((number % 3 == 0) && (number % 7 != 0))
                {
                    File.AppendAllText(file2,Convert.ToString(number)+" ");
                }
            }
            string readFile2 = File.ReadAllText(file2);
            Console.WriteLine($"Числа в файле g: {readFile2}");
        }
    }
}
