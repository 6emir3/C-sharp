using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {            
            int x = -1;
            double y = 7 * Math.Pow( Math.Atan( Math.Pow( Math.Pow(Math.E,x)+1 ,0.5) ),2) + Math.Abs(x);
            Console.WriteLine(y);
        }
    }
}
