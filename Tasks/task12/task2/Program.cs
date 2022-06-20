using System;

namespace task2
{
    class Program
    {
        public delegate double MyDelegat(double a, double b);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действие--> +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("Первое число -->");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Второе число -->");
            double y = Convert.ToDouble(Console.ReadLine());
            switch (a)
            {
                case "+":
                    MyDelegat myDelegat = (c, b) => { return c + b; };
                    double del = myDelegat(x, y);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "-":
                    MyDelegat myDelegat1 = (c, b) => { return c - b; };
                    double del1 = myDelegat1(x, y);
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "*":
                    MyDelegat myDelegat2 = (c, b) => { return c * b; };
                    double del2 = myDelegat2(x, y);
                    Console.WriteLine("Ответ:{0}", del2);
                    break;
                case "/":
                    MyDelegat myDelegat3 = (c, b) => {
                        if ((c != 0) && (b != 0))
                            return c / b;
                        else
                            Console.WriteLine("операция деления на 0 не допускается");
                            return 0;
                    };
                    double del3 = myDelegat3(x, y);
                    if (del3!=0)
                        Console.WriteLine("Ответ:{0}", del3);
                    break;
                default:
                    Console.WriteLine("Выберите из предложанного");
                    break;
            }

            Console.ReadKey();
        }
    }
}
