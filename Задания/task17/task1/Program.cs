using System;

namespace task1
{
    using Figure;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Объект класса треугольник");
            Triangle triangle = new Triangle(3, 3, 3);
            Console.WriteLine("Перметр: "+ triangle.P()+"см");
            Console.WriteLine("Площадь: " +triangle.S()+"cм кв");
            triangle.Vid();
            Console.WriteLine("");

            Console.WriteLine("Объект класса прямоугольник");
            Rectangle rectangle = new Rectangle(10, 5);
            Console.WriteLine("Перметр: " + rectangle.P() + "см");
            Console.WriteLine("Площадь: " + rectangle.S() + "cм кв");
        }
    }
}
