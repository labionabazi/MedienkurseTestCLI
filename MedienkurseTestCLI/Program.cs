using System;

namespace MedienkurseTestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________________________________________________________________\n");
            Tier hund = new Tier("Bello", "Ich beisse", "Hund", "braunes");
            Console.WriteLine("___________________________________________________________________\n");
            Tier katze = new Tier("Lara", "Ich kratze", "Katze", "weisses");
            Console.WriteLine("___________________________________________________________________\n");
            Tier kuh = new Tier("Muh", "Ich gebe 3L Milch", "Kuh", "schwarzes");
            Console.WriteLine("___________________________________________________________________\n");
            Tier pferd = new Tier("Kristina", "Ich beisse", "Pferd", "braunes");
            Console.WriteLine("___________________________________________________________________\n");
            //Katze katze = new Katze("Klein", "Ich bin klein aber flinker als du denken kannst");
            //katze.Greet();
            //katze.Fellfarbe();
            //Console.WriteLine("_______________________________________________________________");
            //Hund hund = new Hund("Morgen", "Ich kann 2h gassi gehen und werde nicht müde");
            //hund.Greet();
            //hund.Fellfarbe();
            //Console.WriteLine("_______________________________________________________________");
            //Kuh kuh = new Kuh("Peige", "Ich produziere 10 liter milch pro tag");
            //kuh.Greet();
            //kuh.Fellfarbe();
            //Console.WriteLine("_______________________________________________________________");
            //Pferd pferd = new Pferd("Ueli", "Ich kann jemand auf mir reiten");
            //pferd.Greet();
            //pferd.Fellfarbe();
            //Console.WriteLine("_______________________________________________________________");

        }
    }
}
