using System;

namespace task4
{
    public delegate void MyInfoDel(string message);
    class MyInfo
    {
        private string name = "Эмир";
        public event MyInfoDel? Call;

        public string Name
        {
            get
            {
                return name;    // возвращаем значение свойства
            }
            set
            {
                Call?.Invoke($"Значение поля name измененно с {name} на {value}");   // 2.Вызов события 
                name = value;   // устанавливаем новое значение свойства
            }
        }
    }
    class Observer1
    {
        public void DisplayMessage(string message) => Console.WriteLine($"1 обработчик: {message}");
    }
    class Observer2
    {
        public void DisplayMessage(string message) => Console.WriteLine($"2 обработчик: {message}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Observer1 ob1 = new Observer1();
            Observer2 ob2 = new Observer2();

            MyInfo m = new MyInfo();
            m.Call += ob1.DisplayMessage;
            m.Call += ob2.DisplayMessage;
            m.Name = "Женя";
           
        }
    }
}
