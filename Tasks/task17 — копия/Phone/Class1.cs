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
        public string Model
        {
            get { return model; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }    
        }
        public double Price 
        { 
            get { return price; } 
        }
        public bool IsAvailable
        {
            get { return available; }
        }
        
    }
}
