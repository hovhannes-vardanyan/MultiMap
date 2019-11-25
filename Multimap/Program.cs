using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMap
{
    class Program
    {
        static void Main(string[] args)
        {
            // karox enq arjeqavorel erku dzevov costruct-ov  ev Add methodov
            // T1 = int ev T2 = string
            Multimap<int, string> map = new Multimap<int, string>(1,new List<string> {"value"});
            map.Add(2, new List<string> { "value", "value" });
            map.Add(3, new List<string> { "value", "value", "value" });
            Console.WriteLine("Before remove");
            map.Print();
            map.Remove(1);
            Console.WriteLine("After Remove");
            map.Print();
            Console.WriteLine("multimap Contains (0) ? "+ map.Contains(0));




            // string ev string
            Console.WriteLine("Multimap T1 = string ev T2 = string");
            Multimap<string, string> strDict = new Multimap<string, string>("hello", new List<string> { "world" });
            strDict.Add("word", new List<string> { "hello" });
            strDict.Print();

            Console.ReadKey();

        }
    }
}
