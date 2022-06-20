using System;

namespace task2
{
    enum Post
    {
        Uborshica = 60,
        Aficant = 120,
        Povar = 130,
        Director = 80
    }

    class Accauntan
    {
        public string name;
        public bool AskForBonus(Post worker, int hours)
        {
            return (hours > (int)worker);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Уборщица должна работать в месяц { (int)Post.Uborshica} часов");
            Console.WriteLine($"Афицант должен работать в месяц { (int)Post.Aficant} часов");
            Console.WriteLine($"Повар должен работать в месяц { (int)Post.Povar} часов");
            Console.WriteLine($"Директор должен работать в месяц { (int)Post.Director} часов");

            Console.WriteLine();

            Accauntan leha = new Accauntan();
            leha.name = "Лёха";

            if (leha.AskForBonus(Post.Director, 80))
                Console.WriteLine($"{Post.Director} {leha.name} достоин премии");
            else
                Console.WriteLine($"{Post.Director} {leha.name} не достоин премии");

            Console.WriteLine();

            Accauntan lena = new Accauntan();
            lena.name = "Лена";

            if (lena.AskForBonus(Post.Aficant, 130))
                Console.WriteLine($"{Post.Aficant} {lena.name} достоина премии");
            else
                Console.WriteLine($"{Post.Aficant} {lena.name} не достоина премии");
        }
    }
}
