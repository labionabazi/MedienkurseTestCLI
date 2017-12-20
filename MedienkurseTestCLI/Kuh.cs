using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    class Kuh : Tier
    {
        public Kuh(string name, string Greet, string Fellfarbe) : base(name, Greet, Fellfarbe)
        {

        }

        public string Bauer { get; set; }

        public void Haltername(string Bauer)
        {
            this.Bauer = Bauer;
            Console.WriteLine("Der Bauer dieser Kuh heisst: " + Bauer);
        }

        public override void Essen()
        {
            Console.WriteLine("Ich habe das Gras gegessen");
        }
    }
}
