using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var l in line)
            {
                if (l == '#')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(l);
                }
            }

            var array = stack.ToArray();
            Array.Reverse(array);
            string newLine = new string(array);
            Console.WriteLine("Обработанная строка: "+newLine);
        }
    }
}