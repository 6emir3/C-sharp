using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _1
{
    class Hike
    {
        public string name;
        public int countP;
        public Hike(string name, int countP)
        {
            this.name = name;
            this.countP = countP;
        }
        virtual public void PrintWeather()
        {
            Console.WriteLine(" В походе-" +name + " количетво человек-" + countP);
        }
    }
    class InfoObj
    {
        public static void Info<tip>(tip obj)
        where tip : Hike
        {
            obj.PrintWeather();
        }
}
class Hi : IEnumerable
{
    private ArrayList list;
    public Hi()
    {
        list = new ArrayList();
    }
    public Hi(ArrayList a)
    {
        list = a;
    }
    public void Add(Hike m)
    {
        list.Add(m);
    }
    public Hi Clone()
    {
        return new Hi(list);
    }
    public void RemoveAt(int i)
    {
        list.RemoveAt(i);
    }
    public void Clear()
    {
        list.Clear();
    }
    public IEnumerator GetEnumerator()
    {
        return list.GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" _____Пример______ ");
        Hike dem = new Hike("Весельчак",13);
        InfoObj.Info<Hike>(dem);
        Console.WriteLine(" _________________ ");
        Hi Hikelist = new Hi();
        Dictionary <int, string>hike = new Dictionary<int, string>(3);
        for (int i = 0; i <3; i++)
{
            Console.WriteLine("Введите название похода");
            string w = null;
            w = Console.ReadLine();
            Console.WriteLine("Введите количество человек в походе");
            int g =Convert.ToInt32( Console.ReadLine());
            
            Hikelist.Add(new Hike(w, g));
            hike[i + 1] = w;
        }
        Console.WriteLine("============ ");
        foreach (KeyValuePair < int, string> keyValue in hike)
{
            Console.WriteLine(keyValue.Key + "-" +keyValue.Value);
        }
        Console.WriteLine("============ ");
        foreach (Hike x in Hikelist)
            x.PrintWeather();
        Hikelist.RemoveAt(1);
        Console.WriteLine("============ ");
        Hi cl = (Hi)Hikelist.Clone();
        foreach (Hike x in cl) x.PrintWeather();
        Console.ReadLine();
    }
}
}