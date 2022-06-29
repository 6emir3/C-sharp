using System;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Factorial(int x)
        { 
            double result = Math.Sin(Math.Pow(x, 2));
            Console.WriteLine($"Значение функции sin(x^2) при x={x} будет равно {Math.Round(result,3)}");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B(оно должно быть больше А): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Parallel.For(a, b+1, Factorial);
        }
        
        
    }
}
