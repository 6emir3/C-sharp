using System;

namespace Figure
{
    public class Triangle
    {
        public double side1;
        public double side2;
        public double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double P()
        {
            return side1 + side2 + side3;
        }
        public double S()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        public string Vid()
        {
            if((side1==side2) && (side1 == side3)) { return"Равносторонний треугольник"; }
            else if ((side1!=side2) && (side1!=side3) && (side2!=side3)){ return "Разносторонний треугольник"; }
            else { return"Равнобедренный треугольник"; }
            
        }
    }
    public class Rectangle
    {
        public double shirina;
        public double dlina;
        public Rectangle(double shirina,double dlina)
        {
            this.shirina = shirina;
            this.dlina = dlina;
        }
        public double P()
        {
            return (shirina+dlina)*2;
        }
        public double S()
        {
            return shirina * dlina;
        }
    }
}
