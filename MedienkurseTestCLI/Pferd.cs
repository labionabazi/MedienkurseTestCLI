using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    class Pferd : Tier
    {
        public Pferd(string name, string Greet, string Fellfarbe) : base(name, Greet, Fellfarbe)
        {

        }

        public int kilometer { get; set; }

        public void hinterlegteStrecke (int km)
        {
            
            
                this.kilometer = km;
                Console.WriteLine("Die hinterlegte Strecke ist: " + km + " km");

        }

        public override void Essen()
        {
            Console.WriteLine("Ich habe das Gras gegessen");
        }
    }
}
