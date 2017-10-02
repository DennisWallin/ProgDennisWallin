using System;
using System.Threading;
namespace FrageSport
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Välkommen! Detta är en frågequiz om mig (Dennis Wallin)!\n ");

            int poang = 0;


            //Fråga 1
            Console.WriteLine("Vad heter Staden jag bor i?:");

            string svar = Console.ReadLine();

            if(svar.ToLower() == "köping")
            {
                Console.WriteLine("\nRätt");
                poang++;
            }
            else
            {
                Console.WriteLine("\nFel");
            }
            Thread.Sleep(1000);



            //Fråga 2
            Console.WriteLine("\nVilket datum föddes jag? Svara med xx/xx-xxxx:" );

            svar = Console.ReadLine();

            if (svar.ToLower() == "28/3-2000")
			{
				Console.WriteLine("\nRätt");
                poang++;
			}
			else
			{
				Console.WriteLine("\nFel");
			}
            Thread.Sleep(1000);



			//Fråga 3
            Console.WriteLine("\nHur lång är jag i cm?:");
            int talsvar = -1;

            while(true)
            {
				try
				{
					talsvar = int.Parse(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("\nSvaret måste vara i sifferform");
				}


				if (talsvar > 180 && talsvar < 190)
				{
					Console.WriteLine("\nRätt");
					poang++;
                    break;
				}
				else
				{
					Console.WriteLine("\nFel, försök igen!/nHur lång är jag i cm?");
					poang--;
				}
				Thread.Sleep(1000);

			}
            //Fråga 4
            Console.WriteLine("\nVad är mitt mellannamn?:");

			svar = Console.ReadLine();

            if (svar.ToLower() == "johan")
			{
				Console.WriteLine("\nRätt");
                poang++;
			}
			else
			{
				Console.WriteLine("\nFel");
			}
            Thread.Sleep(1000);



            //Fråga 5
            Console.WriteLine("\nNämn ett land jag varit i under de senaste 5 åren:");

			svar = Console.ReadLine();

            if (svar.ToLower() == "thailand" || svar.ToLower() == "grekland" || svar.ToLower() == "turkiet")
			{
				Console.WriteLine("\nRätt");
                poang++;
			}
			else
			{
				Console.WriteLine("\nFel");
			}
            Thread.Sleep(1000);



            //Fråga 6
            Console.WriteLine("\nVilken är min favorit aktivitet?:");
           
            svar = Console.ReadLine();

            if (svar.ToLower() == "gym" || svar.ToLower() == "gymma")
            {
                Console.WriteLine("\nRätt");
                poang++;
            }
            else
            {
                Console.WriteLine("\nFel");
            }
            Thread.Sleep(1000);



            //Fråga 7
            Console.WriteLine("\nHur gamal var jag när jag började spela i fotboll? (endast sifra):");
            int talsvar1 = -1;


			try
			{
				talsvar1 = int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Svaret måste vara i sifferform");
			}


			if (talsvar1 == 5 )
            {
                Console.WriteLine("\nRätt");
                poang++;
            }
            else
            {
                Console.WriteLine("\nFel");
            }
            Thread.Sleep(1000);



            //Fråga 8
            Console.WriteLine("\nVilken av dessa måltider är min favorit?:\n" +
                              "1: Pizza (Kebab)\n" +
                              "2: Plankstek\n" +
                              "3: Hamburgare med pommes");


            int val4 = -1;


			try
			{
				val4 = int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("\nSvaret måste vara i sifferform");
			}


            switch (val4)
            {
                case 1:
                    Console.WriteLine("\nRätt" );
                    poang++;
                    break;

                case 2:
                    Console.WriteLine("\nFel");
                    break;

                case 3:
                    Console.WriteLine("\nFel");
                    break;
            }
            Thread.Sleep(1000);



			//Fråga 9
            Console.WriteLine("\nVilket är mitt favorit klädesmärke?:\n" +
							  "1: Jack & Jones\n" +
							  "2: Adidas\n" +
							  "3: Lyle & scott\n" +
                              "4: Tommy hilfiger");

			
            int val1 = -1;


			try
			{
				val1 = int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("\nSvaret måste vara i sifferform");
			}


			switch (val1)
			{
				case 1:
					Console.WriteLine("\nFel");
					break;

				case 2:
					Console.WriteLine("\nRätt");
                    poang++;
					break;

				case 3:
					Console.WriteLine("\nFel");
					break;

                case 4:
                    Console.WriteLine("\nFel");
                    break;
			}
            Thread.Sleep(1000);



            //Fråga 10
            Console.WriteLine("\nVilken skostorlek har jag?:");
            int talsvar2 = -1;

            while(true)
            {
				try
				{
					talsvar2 = int.Parse(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Svaret måste vara i sifferform");
				}


				if (talsvar2 == 44)
				{
					Console.WriteLine("\nRätt");
                    poang++;
                    break;
				}
				else
				{
					Console.WriteLine("\nFel, försök igen!/nVilken skostorlek har jag?");
					poang--;
				}


			}




            Thread.Sleep(1000);
            Console.WriteLine("\nBeräknar poäng....");
            Thread.Sleep(3000);
            Console.WriteLine("\nGrattis du fick " + poang + " av 10 möjliga rätt!");

        }
    }
}
