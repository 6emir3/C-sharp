using System;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static int Repl(int number)
        {
            return (number % 10 * 10 + number % 100 / 10 + number / 1000 * 100 + number / 100 % 10 * 1000);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task task1 = new Task(()=>Console.WriteLine("1 способ: "+Repl(number)));
            task1.Start();
            task1.Wait();

            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("2 способ: " + Repl(number)));
            task2.Wait();

            Task task3 = Task.Run(() => Console.WriteLine("3 способ: " + Repl(number)));
            task3.Wait();



        }
    }
}
