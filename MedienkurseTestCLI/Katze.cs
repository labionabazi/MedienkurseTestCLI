using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    class Katze : Tier
    {
        public Katze(string name, string Greet, string Fellfarbe) : base(name, Greet, Fellfarbe)
        {
            this.name = name;
            this.Greet = Greet;
            this.Fellfarbe = Fellfarbe;
        }
        public bool kratzen { get; set; }

        public void kannKratzen(bool yn)
        {
            

            if(yn)
            {
                this.kratzen = yn;
                Console.WriteLine("Achtung diese Katze krazt");
            }
            else
            {
                Console.WriteLine("Diese Katze kratzt nicht");
            }
                
        }

        public override void Sound()
        {
            Console.WriteLine("Miauu");
        }

        public override void Essen()
        {
            Console.WriteLine("Ich habe die Maus gegessen");
        }
    }
}
