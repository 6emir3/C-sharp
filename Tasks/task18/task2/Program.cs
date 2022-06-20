using System;
using System.IO;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> symbols = new Queue<char>();
            Queue<char> digits = new Queue<char>();


            using (StreamReader sr = new StreamReader("D:\\колледж\\КПиЯП-практика\\-----\\Задания\\task18\\task2\\text.txt"))
            {

                while (!sr.EndOfStream)
                {

                    char s = (char)sr.Read();
                    if (char.IsDigit(s)) digits.Enqueue(s);
                    else symbols.Enqueue(s);

                }

            }

            Console.WriteLine(string.Join("", symbols)+ string.Join("", digits));
        }
    }
}
