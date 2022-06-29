using System;

namespace task2
{
    class A
    {
        int a;
        int b;

        public A(int A, int B)
        {
            a = A;
            b = B;
        }

        public void expression()
        {
            double meaning = 1.0 / (Math.Pow(a, 2)) - 1.0 / (Math.Pow(b, 3));
            Console.WriteLine(Math.Round(meaning, 3));
        }
        public void cube()
        {
            int sum = a + b;
            Console.WriteLine(Math.Pow(sum, 3));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(10, 3);
            a.expression();
            a.cube();
        }
    }
}
