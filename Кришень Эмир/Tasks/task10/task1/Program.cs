using System;

namespace task1
{
    class Flat
    {
        public string name;
        public double price1m2;
        public double square;

        public Flat(string name, double price1m2, double square)
        {
            this.name = name;
            this.price1m2 = price1m2;
            this.square = square;
        }
        public double Price()
        {
            double price = square * price1m2;
            return price;
        }
    }
    class FlatCenter:Flat
    {
        private string district;

        public FlatCenter(string name, double price1m2, double square,string district):base(name,price1m2,square)
        {
            this.name = name;
            this.price1m2 = price1m2;
            this.square = square;
            this.district = district;
        }
        public new double Price()
        {
            double price = base.Price() + base.Price()/100;
            return price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Flat a = new Flat("lol", 3, 14);
            Console.WriteLine("Цена обычной квартиры: " + a.Price());
            FlatCenter b = new FlatCenter("lol1", 3, 14,"Московский");
            Console.WriteLine("Цена квартиры в центре : " + b.Price());

        }
    }
}
