using System;

namespace Loop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hejsan, vilken av följande ekvationer skulle du vilja räkna ut?\n" +
                              "1: f(x) = 2x - 7:\n" +
                              "2: g(x) = x^2 + 10x - 2,5:\n" +
                              "3: h(x) = 3x^5 - x^4 - 4x^3 - 2x^2 + 10x - 25:\n");


			int val = -1;
            while (val > 3 || val < 1)
            {
                try
                {
                    val = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du måste välja 1, 2 eller 3:");
                }
            }

            switch (val)
            {
                case 1:

                    for (int x = -10; x < 11; x++)
                    {
                        double y = 2 * x - 7;

                        Console.WriteLine("x: {0}| f({0})=2*{0}-7={1} ", x, y);
                    }

                    break;

                case 2:

                    for (int x = -10; x < 11; x++)
                    {
                        double y = Math.Pow(x, 2) + 10 * x - 2.5;

                        Console.WriteLine("x: {0}| f({0})=x^2+10*{0}-2.5={1} ", x, y);
                    }

                    break;

                case 3:

                    for (int x = -10; x < 11; x++)
                    {
                        double y = 3 * Math.Pow(x, 5) - Math.Pow(x, 4) - 4 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 10 * x - 25;

                        Console.WriteLine("x: {0}| f({0})=3*x^5-x^4-4*x^3-2*x^2-10*x-25 ", x, y);
                    }


                    break;

            }






		}
    }
}
