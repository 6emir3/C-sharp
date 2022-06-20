using System;

namespace task3
{
    class Program
    {
        static void SortInc3(ref int a,ref int b,ref int c)
        {
            int[] numbers = { a, b, c };
            Array.Sort(numbers);
            a = numbers[0];
            b = numbers[1];
            c = numbers[2];

        }
        static void Main(string[] args)
        {
            Console.Write("Введите а1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b1: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c1: ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            SortInc3(ref a1, ref b1, ref c1);
            Console.WriteLine($"a1: {a1}\nb1: {b1}\nc1: {c1}");

            Console.Write("Введите а2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c2: ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            SortInc3(ref a2, ref b2, ref c2);
            Console.WriteLine($"a2: {a2}\nb2: {b2}\nc2: {c2}");
        }
    }
}
