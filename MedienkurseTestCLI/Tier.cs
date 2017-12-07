using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    class Tier : ITier
    {   
        public Tier(string name, string Spezielles, string Greet, string Fellfarbe)
        {
            Console.WriteLine("Hallo ich bin ein " + Greet);
            Console.WriteLine("Mein Name ist " + name);
            Console.WriteLine("Das Spezielle an mir ist " + Spezielles);
            Console.WriteLine("und ich habe ein " + Fellfarbe + " Fell");
        }
        public string name { get; set; }
        public string Spezielles { get; set; }
        public string Greet { get; set; }
        public string Fellfarbe { get; set; }
        

    }
}
