using System;
using System.Json;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new JsonArray();
            a1.Add("Jos");
            a1.Add("Jan");
            Console.WriteLine(a1.ToString());

            var o1 = new JsonObject();
            o1.Add("Naam", "Jos");
            o1.Add("Leeftijd", "30");
            Console.WriteLine(o1.ToString());

            var a2 = new JsonArray() { "Willy", "Hippoliet" };
            Console.WriteLine(a2.ToString());

            a1.Add(o1);
            a1.Insert(2, a2);

            Console.WriteLine();
            Console.WriteLine(a1.ToString());
        }
    }
}
