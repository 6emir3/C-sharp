using System;

namespace task2
{
    class A
    {
        protected int a = 9;
        protected int b = 3;
        protected int c = 0;

        public A()
        {
        }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }


        public int C
        {
            get
            {
                return c;

            }
            set
            {
                c = value;

                if (a > 5)
                {
                    c *= b;
                }

                else if (a == 5)
                {
                    c++;
                }

                else
                { c = a - b; }

            }

        }
    }

    class B : A
    {
        protected int d;

        public B(int d) : base()
        {
            this.d = d;
        }

        public B(int d, int a, int b) : base(a, b)
        {
            this.d = d;
        }

        public int C2
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
                if (c <= d)
                {
                    c = 66;
                }
                else if (c > a)
                {
                    c *= a;
                }
                else
                {
                    c += b;
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(3, 6);
            a.C = 4;
            Console.WriteLine(a.C);

            B b = new B(0, 10, 6);
            b.C2 = 17;
            Console.WriteLine(b.C2);

            B bb = new B(10);
            bb.C2 = 9;
            Console.WriteLine(bb.C2);
        }

    }
}
