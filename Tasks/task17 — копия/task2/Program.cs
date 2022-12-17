using System;

namespace task2
{
    using Phone;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Объект класса телефон");
            Phone phone = new Phone("iPhone 13", "Apple", 800, true);
            phone.Conclusion();
            phone.Discount(30);

            Console.WriteLine("");
            Console.WriteLine("Телефон после применения скидки");
            phone.Conclusion();
        }
    }
}
