using System;

namespace task1
{
    class Program
    {
        public delegate void Message();

        static void MessageNumber1()
        {
            Console.WriteLine("Сообщение №1");
        }
        static void MessageNumber2()
        {
            Console.WriteLine("Сообщение №2");
        }
        static void MessageNumber3()
        {
            Console.WriteLine("Сообщение №3");
        }
        static void Main(string[] args)
        {
            Message M = new Message(MessageNumber1);
            M += MessageNumber2;
            M += MessageNumber3;
            M();
        }
    }
}
