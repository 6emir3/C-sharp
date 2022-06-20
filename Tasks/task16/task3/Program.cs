using System;
using System.IO;

namespace task3
{
    class Program
    {
        static int CountNotProbelov(string s)
        {
            int kol = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]!=' ')
                {
                    kol++;
                }
            }
            return kol;
        }
        static void Main(string[] args)
        {
            string file1 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\task3\\text1.txt";
            string file2 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\task3\\text2.txt";
            string file3 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\task3\\text3.txt";
            File.WriteAllText(file1, "");
            File.WriteAllText(file2, "");
            File.WriteAllText(file3, "");


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите {i+1} строку: ");
                if (i == 4)
                {
                    File.AppendAllText(file1, Console.ReadLine());
                }
                else
                {
                    File.AppendAllText(file1, Console.ReadLine() + "\n");
                }
            }

            string readFile1 = File.ReadAllText(file1);
            Console.WriteLine("а)Весь файл:\n"+readFile1);

            string[] numbers = readFile1.Split("\n");
            int kol=0;

            for (int i = 0; i < numbers.Length; i++)
            {
                kol++;
            }
            Console.WriteLine("b)Количество строк: " + kol);

            Console.WriteLine("c)");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Количество символов в {i + 1} строке: {CountNotProbelov(numbers[i])}");
            }

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (i == numbers.Length - 2)
                {
                    File.AppendAllText(file2, numbers[i]);
                }
                else
                {
                    File.AppendAllText(file2, numbers[i] + "\n");
                }
            }
            string readFile2 = File.ReadAllText(file2);
            Console.WriteLine($"d)Новый файл с удаленной строкой\n{readFile2}");

            Console.WriteLine("Введите номер строки с какой хотите начать просмотр: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер строки на которой хотите закончить просмотр: ");
            int stop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"e)Строки с {start} по {stop}");
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i + 1 >= start) && (i + 1 <= stop))
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            int max = numbers[0].Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Length > max) { max = numbers[i].Length; }
            }
            Console.WriteLine("f)Длинна самой длинной строки: "+max);

            Console.Write("Введите букву: ");
            char later = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("g)Строки которые начинаются на букву " + later+":");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != "")
                {
                    if (numbers[i][0] == later) { Console.WriteLine(numbers[i]); }
                }
            }

            for (int i = numbers.Length-1; i >=0; i--)
            {
                if (i == 0)
                {
                    File.AppendAllText(file3, numbers[i]);
                }
                else
                {
                    File.AppendAllText(file3, numbers[i] + "\n");
                }
            }
            string readFile3 = File.ReadAllText(file3);
            Console.WriteLine("h)Файл строки в котором расположенны в обратном порядке:\n" + readFile3);
        }
    }
}
