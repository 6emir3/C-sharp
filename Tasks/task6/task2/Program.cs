using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string offer = Console.ReadLine();
            Console.Write("Введите длину: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = offer.Split(' ', ',');
            
            Array.Sort(words, StringComparer.InvariantCulture);

            foreach (string word in words)
            {
                if (word.Length == n)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
