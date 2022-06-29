using System;

namespace task1
{
    class Drob
    {
        double chislitel;
        double znamenatel;
 
        public Drob() { }

        public Drob(double chislit, double znamenat)
        {
            chislitel = chislit;
            znamenatel = znamenat;
        }
        
        public void Conclusion()
        {
            Console.WriteLine($"{chislitel}/{znamenatel}");
        }

        public void Plus(Drob drob)
        {
            Drob newDrob = new Drob();
            newDrob.chislitel = chislitel * drob.znamenatel + znamenatel * drob.chislitel;
            newDrob.znamenatel = znamenatel * drob.znamenatel;
            newDrob.Conclusion();
        }

        public void Minus(Drob drob)
        {
            Drob newDrob = new Drob();
            newDrob.chislitel = chislitel * drob.znamenatel - znamenatel * drob.chislitel;
            newDrob.znamenatel = znamenatel * drob.znamenatel;
            newDrob.Conclusion();
        }
        public void Multiplication(Drob drob)
        {
            Drob newDrob = new Drob();
            newDrob.chislitel = chislitel * drob.chislitel;
            newDrob.znamenatel = znamenatel * drob.znamenatel;
            newDrob.Conclusion();
        }
        
        public void Division(Drob drob)
        {
            Drob newDrob = new Drob();
            newDrob.chislitel = chislitel * drob.znamenatel;
            newDrob.znamenatel = znamenatel * drob.chislitel;
            newDrob.Conclusion();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Drob a = new Drob(4, 8);
            Drob b = new Drob(2, 5);
            a.Plus(b);
            a.Minus(b);
            a.Multiplication(b);
            a.Division(b);
        }
    }
}
