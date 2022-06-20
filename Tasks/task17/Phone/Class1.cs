using System;

namespace Phone
{
    public class Phone
    {
        string model;
        string manufacturer;
        double price;
        bool available;

        public Phone(string model,string manufacturer,double price,bool available)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.available = available;
        }

        public void Discount(int discount)
        {
            price *= discount / 100.0;
        }
        public void Conclusion()
        {
            Console.WriteLine($"модель: {model}");
            Console.WriteLine($"производитель: {manufacturer}");
            Console.WriteLine($"цена: {price}$");
            if (available) { Console.WriteLine("есть в наличии"); }
            else { Console.WriteLine("нет в наличии"); }
        }
    }
}
