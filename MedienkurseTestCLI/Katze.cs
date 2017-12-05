using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    class Katze : Tier
    {
        public Katze(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine("Hallo ich bin eine Katze");
        }
    }
}
