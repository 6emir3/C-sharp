using System;

namespace task2
{
    class Array
    {
        public string[] lines;
        public Array(int size)
        {
            lines = new string[size];
        }
        public void Filling()
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("Введите строку");
                lines[i] = Console.ReadLine();
            }
        }
        public void Conclusion()
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i]+" ");
            }
            Console.WriteLine();
        }
        public void Appeal(int index)
        {
            if ((index>lines.Length-1) || (index < 0))
            {
                Console.WriteLine("Индекс вышел за пределы массива");
            }
            else
            {
                Console.WriteLine(lines[index]);
            }
        }
        public void AppealArray(int index)
        {
            Conclusion();
            Appeal(index);
        }
        public static Array operator +(Array MyArray1, Array MyArray2)
        {
            string[] newLines = new string[Math.Max(MyArray1.lines.Length, MyArray2.lines.Length)];
            for (int i = 0; i < newLines.Length; i++)
            {
                if (i > MyArray1.lines.Length - 1)
                {
                    newLines[i] = MyArray2.lines[i];
                }
                else if (i > MyArray2.lines.Length - 1)
                {
                    newLines[i] = MyArray1.lines[i];
                }
                else
                {
                    newLines[i] = MyArray1.lines[i] + MyArray2.lines[i];
                }

            }
            Array newArray = new Array(newLines.Length);
            newArray.lines = newLines;
            return newArray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array array1 = new Array(3);
            array1.Filling();
            Console.Write("1 массив: ");
            array1.Conclusion();

            Array array2 = new Array(2);
            array2.Filling();
            Console.Write("2 массив: ");
            array2.Conclusion();

            Array array3 = array1 + array2;
            Console.Write("3 массив: ");
            array3.Conclusion();
            array3.Appeal(2);
            array3.AppealArray(0);
        }
    }
}
