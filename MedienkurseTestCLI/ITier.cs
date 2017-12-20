using System;
using System.Collections.Generic;
using System.Text;

namespace MedienkurseTestCLI
{
    interface ITier
    {
        string Greet { get; set; }
        string Fellfarbe { get; set; }
        string name { get; set; }
        StatusEnum Status { get; set; }
        void Sound();
        void Essen();


    }
}
