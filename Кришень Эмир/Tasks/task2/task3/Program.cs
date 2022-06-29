using System;

namespace task3
{
    public class State
    {
        public int cities;
        public int square;
        public string rulersName;
        public string name;

        public State(int cities, int square, string name)
        {
            this.cities = cities;
            this.square = square;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine($"название {name}");
            Console.WriteLine($"количество городов {cities}");
            Console.WriteLine($"площадь {square} кв.км");
        }
    }

    public class Republic : State 
    {

        public string president;
        public Republic(int cities, int square, string name, string president) : base(cities,square,name)
        {
            this.cities = cities;
            this.square = square;
            this.name = name;
            this.president = president;
        }

        public new void Print() 
        {
            Console.WriteLine($"имя президента {president}");
            base.Print();
        }
    }

    public class Monarchy : State
    {

        public string titleMonarch;
        public string nameMonarch;
        public Monarchy(int cities, int square, string name, string titleMonarch, string nameMonarch) : base(cities, square, name)
        {
            this.cities = cities;
            this.square = square;
            this.name = name;
            this.titleMonarch = titleMonarch;
            this.nameMonarch = nameMonarch;
        }

        public new void Print()
        {
            Console.WriteLine($"имя монарха {nameMonarch}");
            Console.WriteLine($"титул монарха {titleMonarch}");
            base.Print();
        }
    }

    public class kingdom : State
    {

        public string queen;
        public string king;
        public kingdom(int cities, int square, string name, string queen, string king) : base(cities, square, name)
        {
            this.cities = cities;
            this.square = square;
            this.name = name;
            this.queen = queen;
            this.king = king;
        }

        public new void Print()
        {
            Console.WriteLine($"имя короля {king}");
            Console.WriteLine($"имя королевы {queen}");
            base.Print();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            State s1 = new State(12, 263, "Беларусь");
            Console.WriteLine($"Государство");
            s1.Print();
            Republic s2 = new Republic(4, 108, "Россия", "Вовка");
            Console.WriteLine($"\nРеспублика");
            s2.Print();
            Monarchy s3 = new Monarchy(22, 442, "США", "Король","Саймон");
            Console.WriteLine($"\nМонархия");
            s3.Print();
            kingdom s4 = new kingdom(37, 681, "Чечня", "Елизавета", "Абдула");
            Console.WriteLine($"\nКоролевство");
            s4.Print();
        }
    }
}
