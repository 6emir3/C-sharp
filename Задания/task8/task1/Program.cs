using System;

namespace task1
{
    struct NOTE : IComparable
    {
        public string name;
        public string surname;
        public string phone;
        public int[] data ;

        public NOTE(string name,string surname, string phone, int day, int month,int year)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            data = new int[3];
            data[0] = day;
            data[1] = month;
            data[2] = year;
        }

        public int CompareTo(object? o)
        {
            if (o is NOTE people) return phone.CompareTo(people.phone);
            else throw new ArgumentException("Некорректное значение параметра");
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Фаамилия: {surname}  Телефон: {phone}  Дата рождения: {data[0]}.{data[1]}.{data[2]}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NOTE[] people = new NOTE[3];
            people[0] = new NOTE("Sasha", "Tugai", "+375 33 901 50 73", 24, 11, 2005);
            people[1] = new NOTE("Emir", "Krishen", "+973 33 376 37 12", 16, 12, 2003);
            people[2] = new NOTE("Lesha", "Budzko", "+238 29 121 99 87", 13, 10, 2004);
            Array.Sort(people);

            for (int i = 0; i < people.Length; i++)
            {
                people[i].Print();
            }

            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < people.Length; i++)
            {
                if (people[i].surname == surname)
                {
                    people[i].Print();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Таких нету");
            }
        }
    }
}
