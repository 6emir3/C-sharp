using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace task5
{
    class Program
    {
        static void Factorial(int x, ParallelLoopState pls)
        {
            long work = 1;
            for (int i = 1; i <= x; i++)
            {
                work *= i;
            }
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }

            if ((work > 300) && (sum > 300))
            {
                pls.Break();
            }
            Console.WriteLine($"Сумма: {sum}, произведение: {work}");
            
        }
        
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach<int> (new List<int>() { 47, 16, 34, 87, 23 }, Factorial);
            if (!result.IsCompleted)
                Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");

        }
    }
}
