using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    abstract class Tier : ITier
    {
        public Tier(string name, string Greet, string Fellfarbe)
        {
            Console.WriteLine("Hallo ich bin ein " + Greet);
            Console.WriteLine("Mein Name ist " + name);
            Console.WriteLine("und ich habe ein " + Fellfarbe + " Fell");
            //Console.WriteLine("Das Spezielle an mir ist " + Spezielles);
        }
        //public string Spezielles { get; set; }
        public StatusEnum Status { get; set; }
        public string name { get; set; }
        public string Greet { get; set; }
        public string Fellfarbe { get; set; }
        
        public virtual void Sound()
        {
            Console.WriteLine("Ich mache ein Geräusch");
        }

        public abstract void Essen();

    }
}
