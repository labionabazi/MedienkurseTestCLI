using System;

namespace MedienkurseTestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Katze katze = new Katze("Klein");
            katze.Greet();
            Console.WriteLine(katze.Name);
        }
    }
}
