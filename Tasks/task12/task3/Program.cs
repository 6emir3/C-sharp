using System;

namespace task3
{
    class Program
    {
        public delegate string StringDelegate (string line);
        static string Increase(string line)
        {
            Console.WriteLine($"строка с увеличенным регистром: {line.ToUpper()}");
            return line.ToUpper();
        }
        static string TurnOver(string line)
        {
            char[] sReverse = line.ToCharArray();
            Array.Reverse(sReverse);
            line = new string(sReverse);
            Console.WriteLine($"строка задом наперед: {line}");
            return line;
        }
        static string Decrease(string line)
        {
            Console.WriteLine($"строка с уменьшенным регистром: {line.ToLower()}");
            return line.ToLower();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string line = Console.ReadLine();
            StringDelegate SD = new StringDelegate(Increase);
            SD += TurnOver;
            SD += Decrease;
            SD(line);
        }
    }
}
