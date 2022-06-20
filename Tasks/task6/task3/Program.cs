using System;

namespace task3
{
    class Program
    {
        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string offer = Console.ReadLine();
            string[] words = offer.Split(' ', ',');
            offer = "";
            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;

            
            for (int i = 0; i < words.Length; i++)
            {
                if(i == 0)
                {
                    words[i] =words[i].Substring(2);
                    offer += words[i] + " ";
                }
                else if (i == 1)
                {
                    offer += words[i];
                }
                else if (i == 3)
                {
                    words[i] = ReverseString(words[i]);
                    offer += words[i] + " ";
                }
                else 
                {
                    offer += words[i] + " ";
                }
                
            }
            Console.WriteLine(offer);
            
        }
    }
}
