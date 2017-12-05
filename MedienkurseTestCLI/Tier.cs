using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    abstract class Tier : ITier
    {
        public Tier(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public abstract void Greet();
    }
}
