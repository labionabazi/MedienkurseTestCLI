using System;
using System.Collections.Generic;

namespace MedienkurseTestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________________________________________________________________\n");
            Hund hund = new Hund("Bello", "Hund", "braunes");
            hund.updateKnochen(5);
            //----------------------------------------------------------------------------------------
            List<string> Hunde = new List<string>
            {
                "Hund3",
                "Hund2",
                "Hund1",
                "Hund4"
            };


            Console.WriteLine("__________________\n");
            Console.WriteLine("Die Hunde werden mit einem foreach ausgegeben und sind nicht sortiert\n");
            foreach (string Hun in Hunde)
            {
                Console.WriteLine(Hun);
            }


            Console.WriteLine("__________________\n");
            Console.WriteLine("Die Hunde werden mit einem for ausgegeben und wurden sortiert\n");
            Hunde.Sort();
            for (int i = 0; i < Hunde.Count; i++)
            {
                Console.WriteLine(Hunde[i]);
            }


            Console.WriteLine("__________________\n");
            Console.WriteLine("Der Hund4 wird entfernt\n");
            Hunde.Remove("Hund4");
            Hunde.Sort();
            for (int i = 0; i < Hunde.Count; i++)
            {
                Console.WriteLine(Hunde[i]);
            }


            Console.WriteLine("__________________\n");
            Console.WriteLine("Es wird überprüft ob Hund1 schon existiert\n");
            if (Hunde.Contains("Hund1"))
            {
                Console.WriteLine("Hund1 existiert schon");
            }

            
            Console.WriteLine("__________________\n");
            Console.WriteLine("Jezt Leere ich den Inhalt der Liste\n");
            Hunde.Clear();
            if (Hunde.Count == 0 )
            {
                Console.WriteLine("Die Liste ist leer");
            }
            else
            {
                Console.WriteLine("In der Liste ist noch etwas drinn bitte lösche den Inhalt nochmal");
            }



            Console.WriteLine("___________________________________________________________________\n");
            Katze katze = new Katze("Lara", "Katze", "weisses");
            katze.kannKratzen(true);
            katze.kannKratzen(false);
            katze.Status = StatusEnum.Satt;
            Console.WriteLine(katze.Status);
            bool istSatt = katze.Status == StatusEnum.Satt ? true : false;
            Console.WriteLine(istSatt);
            katze.Sound();
            katze.Essen();


            Console.WriteLine("___________________________________________________________________\n");
            Kuh kuh = new Kuh("Muh", "Kuh", "schwarzes");
            kuh.Haltername("Markus");


            Console.WriteLine("___________________________________________________________________\n");
            Pferd pferd = new Pferd("Kristina", "Pferd", "braunes");
            pferd.hinterlegteStrecke(12);


            Console.WriteLine("___________________________________________________________________\n");

            //Modulo
            int modulo = 9 % 5;

            Console.WriteLine(modulo);

            //Nullable Types
            int? nummer1 = 45;
            int? nummer2 = 5;
            int? result = nummer2 + nummer1;
            Console.WriteLine("The result is: " + result);
            Console.WriteLine("___________________________________________________________________\n");
        }
    }
}
