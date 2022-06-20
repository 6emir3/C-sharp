using System;
using System.IO;

namespace taskDop2
{
    class Program
    {
        static int CountNotProbelov(string s)
        {
            int kol = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    kol++;
                }
            }
            return kol;
        }
        static void Main(string[] args)
        {
            string file1 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\taskDop2\\input.txt";
            File.WriteAllText(file1, "");
            string file2 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\taskDop2\\output1.txt";
            File.WriteAllText(file2, "");
            string file3 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\taskDop2\\output2.txt";
            File.WriteAllText(file3, "");
            string file4 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\taskDop2\\output3.txt";
            File.WriteAllText(file4, "");
            string file5 = "D:\\колледж\\КПиЯП-практика\\Задания\\task16\\taskDop2\\output4.txt";
            File.WriteAllText(file5, "");

            Console.Write("Введите количество строк: ");
            int kol = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("input.txt:\n" + readFile1);

            string[] file1Text = readFile1.Split("\n");

            for (int i = 0; i < file1Text.Length; i++)
            {
                File.AppendAllText(file2, file1Text[i]+$" (номер строки:{i+1}, количество символов:{CountNotProbelov(file1Text[i])})");
                
                if (i != file1Text.Length - 1)
                {
                    File.AppendAllText(file2, "\n");
                }
            }
            string readFile2 = File.ReadAllText(file2);
            Console.WriteLine("output1.txt:\n" + readFile2);


            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < file1Text.Length; i++)
            {
                if (file1Text[i].Length > number)
                {
                    File.AppendAllText(file3, file1Text[i]);

                    if (i != file1Text.Length - 1)
                    {
                        File.AppendAllText(file3, "\n");
                    }
                }
            }
            string readFile3 = File.ReadAllText(file3);
            Console.WriteLine("output2.txt:\n" + readFile3);

            for (int i = 0; i < file1Text.Length; i++)
            {
                if (file1Text[i].Length % 2==0)
                {
                    File.AppendAllText(file4, file1Text[i]);

                    if (i != file1Text.Length - 1)
                    {
                        File.AppendAllText(file4, "\n");
                    }
                }
            }
            string readFile4 = File.ReadAllText(file4);
            Console.WriteLine("output3.txt:\n" + readFile4);

            for (int i = 0; i < file1Text.Length; i++)
            {
                for (int j = 0; j < file1Text[i].Length; j++)
                {
                    if ((j + 1) % 2 == 0)
                    {
                        File.AppendAllText(file5,Convert.ToString(file1Text[i][j]));
                    }
                }
                if (i != file1Text.Length - 1)
                {
                    File.AppendAllText(file5, "\n");
                }
            }
            string readFile5 = File.ReadAllText(file5);
            Console.WriteLine("output4.txt:\n" + readFile5);
        }
    }
}
