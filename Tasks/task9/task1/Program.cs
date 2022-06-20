using System;
namespace Interface01
{
    interface Ix
    {
        void IxF0(double xKey);
        void IxF1();
    }
    // Пара интерфейсов, содержащих объявления одноимённых методов
    // с одной и той же сигнатурой.
    interface Iy
    {
        void F0(double xKey);
        void F1();
    }
    interface Iz
    {
        void F0(double xKey);
        void F1();
    }



// А этому интерфейсу уделим особое внимание.
// Он содержит тот же набор методов, но в производном классе этот интерфейс
// будет реализован явным образом.


    //В классе TestClass наследуются интерфейсы...
    class TestClass : Ix, Iy, Iz
    {
        public double w;
        //Конструкторы.
        public TestClass()
        {
            w = 125;
        }
        public TestClass(double key)
        {
            w = key;
        }
        //Реализация функций интерфейса Ix.
        //Этот интерфейс имеет специфические названия функций.
        //В данном пространстве имён его реализация неявная и однозначная.

        public void IxF0(double w)
        {
            w = Math.Pow(w,2);
            Console.WriteLine("IxF0({0})", w);
        }
    public void IxF1()
        {
            w = Math.Pow(w,2);
            Console.WriteLine("IxF1({0})", w);
        }
        // Реализация интерфейсов Iy и Iz в классе TestClass неразличима.
        // Это неявная неоднозначная реализация интерфейсов.
        // Однако, неважно, чью конкретно функцию реализуем. Оба интерфейса довольны...
    public void F0(double w)
        {
            w = Math.Sqrt(w);
            Console.WriteLine("(Iy/Iz)F0({0})", w);
        }
     public void F1()
        {
            w = Math.Sqrt(w);
            Console.WriteLine("(Iy/Iz)F1({0})", w);
        }
        //А это явная непосредственная реализация интерфейса Iw.
        //Таким образом, класс TestClass содержит ТРИ варианта реализации
        //функций интерфейсов с одной и той же сигнатутой.Два варианта реализации неразличимы.
    //Третий(фактически второй) вариант реализации отличается квалифицированными именами.
    void Iz.F0(double w)
        {
            w = Math.Pow(w,2) + 5;
            Console.WriteLine("Iz.F0({0})", w);
        }
        void Iz.F1()
        {
            w = Math.Pow(w, 2) + 5;
            Console.WriteLine("Iz.F1({0})", w);
        }
        
}
class Class1
{
    static void Main(string[] args)
    {
        TestClass x0 = new TestClass();
        TestClass x1 = new TestClass(125);
       
        //Эти методы представляют собой неявную ОДНОЗНАЧНУЮ реализацию интерфейса Ix.
        x0.IxF0(10);
        x1.IxF1();
        // Эти методы представляют собой неявную НЕОДНОЗНАЧНУЮ
        //реализацию интерфейсов Iy и Iz.
        x0.F0(5);
        x1.F1();
        // А вот вызов функций с явным приведением к типу интерфейса.
        // Собственный метод класса bF0() при подобных преобразованиях не виден.
        (x0 as Iy).F0(7);
        (x1 as Iz).F1();
        // А теперь настраиваем ссылки различных типов интерфейсов
        // на ОДИН И ТОТ ЖЕ объект-представитель класса TestClass.
        // И через "призму" интерфейса всякий раз объект будет
        // выглядеть по-разному.
        
        Console.WriteLine("==========Ix==========");
        Ix ix = x1;
        ix.IxF0(5);
        ix.IxF1();
    
        Console.WriteLine("==========Iy==========");
        Iy iy = x1;
        iy.F0(5);
        iy.F1();

        Console.WriteLine("==========Iz==========");
        Iz iz = x1;
        iz.F0(5);
        iz.F1();
        
    }
}
}