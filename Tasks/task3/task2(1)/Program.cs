using System;

namespace task2_1_
{
    class MyArray
    {
        int[,] A;
        public int numberOfLines;
        public int numberOfColumns;



        public MyArray(int numberOfLines,int numberOfColumns)
        {
            this.numberOfLines = numberOfLines;
            this.numberOfColumns = numberOfColumns;
            A = new int[numberOfLines, numberOfColumns];
        }

        public void ArrayInt_RandomIn(int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < numberOfLines; i++)
                for (int j = 0; j < numberOfColumns; j++)
                    A[i, j] = rnd.Next(max + 1);
        }

        public void ArrayInt_Out()
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                    Console.Write(A[i, j].ToString() + "\t");
                Console.WriteLine();
            }
        }

        public static MyArray operator +(MyArray MyArray1, MyArray MyArray2)
        {
            for (int i = 0; i < MyArray1.numberOfLines; i++)
                for (int j = 0; j < MyArray1.numberOfColumns; j++)
                {
                    int inc = MyArray1.A[i, j] + MyArray2.A[i, j];
                    MyArray1.A[i, j] = inc;
                }
            return MyArray1;
        }

        public static MyArray operator -(MyArray MyArray1, MyArray MyArray2)
        {
            for (int i = 0; i < MyArray1.numberOfLines; i++)
                for (int j = 0; j < MyArray1.numberOfColumns; j++)
                {
                    int inc = MyArray1.A[i, j] - MyArray2.A[i, j];
                    MyArray1.A[i, j] = inc;
                }
            return MyArray1;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(3,5);
            a.ArrayInt_RandomIn(10);
            a.ArrayInt_Out();
            Console.WriteLine();

            MyArray b = new MyArray(3,5);
            b.ArrayInt_RandomIn(10);
            b.ArrayInt_Out();
            Console.WriteLine();

            MyArray c = new MyArray(3,5);
            c.ArrayInt_RandomIn(20);
            c.ArrayInt_Out();
            Console.WriteLine();

            a += b;
            a.ArrayInt_Out();
            Console.WriteLine();

            c -= b;
            c.ArrayInt_Out();
        }
    }
}
