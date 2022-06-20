using System;
using System.Text;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int kod = 0;
            char[] alf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Введите фамилия, имя и отчество на английском языке: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < a.Length; ++i)
            {
                kod += Array.IndexOf(alf, a[i]) + 1;
            }
            Console.WriteLine(kod);

            int sum = 0;
            do
            {
                sum = 0;
                while (kod != 0)
                {
                    sum += kod % 10;
                    kod = kod / 10;
                }
                kod = sum;
            } 
            while (sum / 10 != 0);
            
            Console.WriteLine(sum);
        }
    }
}
