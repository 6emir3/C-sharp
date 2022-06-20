using System;
using System.Threading;

namespace task1
{
    class Program
    {
        static object lockObj = new object();
        static void FirstThread()
        {
            for (int i=0;i<10;i++)
            {
                Thread.Sleep(100);
                WriteLine($"Первый поток говорит: {i}",ConsoleColor.Red);
                Thread.Sleep(100);

            }
        }
        static void SecondThread()
        {
            for (int i = 10; i<20; i++)
            {
                Thread.Sleep(100);   
                WriteLine($"Второй поток говорит: {i}", ConsoleColor.Yellow);
                Thread.Sleep(100);
            }
        }
        static void ThirdThread()
        {
            for (int i = 20; i<30; i++)
            {
           
                Thread.Sleep(100);
                WriteLine($"Третий поток говорит: {i}", ConsoleColor.Green);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Lowest;
            thread1.Start();
   
            Thread.Sleep(100);
            thread2.Start();

            Thread.Sleep(100);
            thread3.Start();

        }
        static void WriteLine(string text, ConsoleColor color)
        {
            lock (lockObj)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.White;
            }            
        }
    }
}
