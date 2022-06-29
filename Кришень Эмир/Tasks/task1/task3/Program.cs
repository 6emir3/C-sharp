using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер пассажира");
            int nomberPassenger = Convert.ToInt32(Console.ReadLine());
                switch (nomberPassenger)
                {
                    case 4: case 5: case 6: case 7: case 8:
                    Console.WriteLine("Грязный");
                        break;
                    case 3: case 9: case 12:
                    Console.WriteLine("Исцарапанный");
                        break;
                    case 1: case 2: case 10: case 11:
                    Console.WriteLine("Целый");
                        break;
                }
            
        }
    }
}
