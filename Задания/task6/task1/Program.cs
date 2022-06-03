using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string offer = Console.ReadLine();
            Console.Write("Введите символ: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            string[] words = offer.Split(' ',',');
            offer = "";

            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                if (words[i].EndsWith(symbol))
                {
                    words[i] = "";
                }
                else if (words[i]=="")
                {
                    words[i] = ",";
                }
                offer += words[i] + " ";
            }
            Console.WriteLine(offer);

        }
    }
}
