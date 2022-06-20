using System;

namespace task1
{
    class MyList<T>
    {
        protected int index = 0;
        protected T[] Values = new T[0];
        
        public void Add(T value)
        {
            Array.Resize(ref Values, index+1);

            Values[index] = value;
            index++;
        }
        public T this[int index]
        {
            get => Values[index];
        }
        
        public int Length
        {
            get => Values.Length ; 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList <int> list = new MyList<int>();
            list.Add(32994);
            list.Add(200002);
            list.Add(101);
            Console.WriteLine("Элемент с индексом 1: " + list[1]);
            Console.WriteLine("Длина: " + list.Length);
        }
    }
}
