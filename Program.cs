using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonDemo
{
    class Program
    {
        class Mens
        {
            public string Naam { get; set; }
            public int Leeftijd { get; set; }
        }

        static void Main(string[] args)
        {
            var mensen = new List<Mens>()
            {
                { new Mens { Naam = "Jan", Leeftijd = 30 } },
                { new Mens { Naam = "Jos", Leeftijd = 31 } },
                { new Mens { Naam = "Willy", Leeftijd = 32 } },
                { new Mens { Naam = "Hippoliet", Leeftijd = 29 } },
            };

            var str = JsonSerializer.Serialize(mensen);
            Console.WriteLine(str);

            var options = new JsonSerializerOptions { WriteIndented = true };
            Console.WriteLine(JsonSerializer.Serialize(mensen, options));
        }
    }
}
