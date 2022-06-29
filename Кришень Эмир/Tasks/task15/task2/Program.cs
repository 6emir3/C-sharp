using System;


namespace task2
{
    class MyDictionary<TKey,TValue>
    {
        protected int index = 0;
        protected TKey[] Keys = new TKey[0];
        protected TValue[] Values = new TValue[0];

        public void Add(TKey key, TValue value)
        {
            if (Array.IndexOf(Keys, key) == -1)
            {
                Array.Resize(ref Keys, index + 1);
                Keys[index] = key;

                Array.Resize(ref Values, index + 1);
                Values[index] = value;

                index++;
            }
            else { Console.WriteLine("Значение с таким ключем уже существуюе"); }
        }
        public TValue this[TKey index]
        {
            get => Values[Array.IndexOf(Keys,index)];
        }

        public int Length
        {
            get => Values.Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> list = new MyDictionary<string, int>();
            list.Add("lol",32994);
            list.Add("popit",200002);
            list.Add("shazam",101);
            list.Add("popit", 5345353);
            Console.WriteLine("Элемент с ключем popit: " + list["popit"]);
            Console.WriteLine("Количество пар: " + list.Length);
        }
    }
}
