using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    class Hund : Tier
    {
        public Hund(string name, string Greet, string Fellfarbe) : base(name, Greet, Fellfarbe)
        {
            this.name = name;
            this.Greet = Greet;
            this.Fellfarbe = Fellfarbe;
        }
        public int anzahlKnochen { get; private set; }

        public void updateKnochen(int anzahl)
        {
            if(anzahl > 0)
            {
                this.anzahlKnochen = anzahl;
                Console.WriteLine("Knochen nach Update:" + this.anzahlKnochen);
            }
        }

        public override void Essen()
        {
            Console.WriteLine("Ich habe das Fleisch gegessen");
        }
    }
}
