using System;

namespace Myfirstprog
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Skriv ditt namn:");

            string namn;

            namn = Console.ReadLine();

            Console.WriteLine("Skriv nu in din ålder: ");

            String ålder;

            ålder = Console.ReadLine();

            Console.WriteLine("Skriv in din adress:");

            string adress;

            adress = Console.ReadLine();
           
            Console.WriteLine("Har du några fritidsintressen? Nämn gärna några:");

            String fritidsintressen;

            fritidsintressen = Console.ReadLine();

            Console.WriteLine("Hej " + namn + " och välkommen till mitt första program. Din adress är alltså: \n"
                              + adress + ". Vad roligt att du också tycker om " + fritidsintressen + 
                              ". Det passar \nverkligen dig som är " + ålder + ".");

		}
    }
}
