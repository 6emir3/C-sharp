using System;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\task4\\text1.txt";
            File.WriteAllText(file1, "");
            string file2 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\task4\\text2.txt";
            File.WriteAllText(file2, "");

            Console.Write("Введите количество строк: ");
            int kol =Convert.ToInt32( Console.ReadLine());

            for (int i = 1; i <= kol; i++)
            {
                Console.Write($"Введите {i} строку: ");
                if (i == kol)
                {
                    File.AppendAllText(file1, Console.ReadLine());
                }
                else
                {
                    File.AppendAllText(file1, Console.ReadLine() + "\n");
                }
            }

            string readFile1 = File.ReadAllText(file1);
            Console.WriteLine("1 файл:\n" + readFile1);

            string[] file1Text = readFile1.Split("\n");
            for (int i = 0; i <file1Text.Length; i++)
            {
                for(int j = 0; j < file1Text[i].Length; j++)
                {
                    if (file1Text[i][j] == '0') 
                    {
                        File.AppendAllText(file2, "1");
                    }
                    else if (file1Text[i][j] == '1')
                    {
                        File.AppendAllText(file2, "0");
                    }
                    else
                    {
                        File.AppendAllText(file2,Convert.ToString(file1Text[i][j]));
                    }
                }
                if (i!= file1Text.Length - 1) { File.AppendAllText(file2, "\n"); }  
            }
            string readFile2 = File.ReadAllText(file2);
            Console.WriteLine("2 файл:\n" + readFile2);
        }
    }
}
