using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double f;
                if ((0 < x) && (x < 1))
                {
                    f = x * Math.Cos(x);
                }
                else if (1 <= x)
                {
                    f = 12 / (3 * x - 3);
                }
                else
                {
                    throw new Exception("выход из диапазона допустимых значений x");
                }
                if (Double.IsInfinity(f))
                {
                    Console.WriteLine("Бесконечность");
                }
                else
                {
                    Console.WriteLine(f);
                }
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Нужно ввести число");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на 0 нельзя!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}
