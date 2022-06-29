using System;

namespace task2_2_
{
    class Product
    {
        string name;
        string nameShop;
        double price;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string NameShop
        {
            get
            {
                return nameShop;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }
        public Product() { }

        public Product(string name,string nameShop,double price)
        {
            this.name = name;
            this.nameShop = nameShop;
            this.price = price;
        }

        public void Conclusion()
        {
            Console.WriteLine($"название товара: {Name}");
            Console.WriteLine($"название магазина: {NameShop}");
            Console.WriteLine($"стоимость товара: {Price}р");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Самокат", "Копеечка", 12.4);
            p.Conclusion();
        }
    }
}
