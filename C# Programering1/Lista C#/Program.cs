﻿//Murtadha Alobaidi
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        // detta är en statisk metod med en int som ett returvärde
        // metoden tar en parameter i form av ett random objekt av
        // randomklassen

        //För att returvärde
        static int RullaTärning(Random slumpObjekt)

        {
            int tal = slumpObjekt.Next(1,7);
            return tal;
        }

        static void Main()
        {
            // Title för min arbeta för övning 2
            Console.Title = "Murtadha Alobaidi NTI skolan / Programering 1/ Övning 6";


            Random slump = new Random(); // Skapar en instans av klassen Random för vårt slumptal
            List<int> tärningar = new List<int>(); // listan för att spara våra rullade tärningar
            Console.WriteLine("\n\tVälkommen till tärningsgeneratorn!");

            bool kör = true;
            while (kör)
            {
                Console.WriteLine("\n\t[1] Rulla tärning\n" +
                    "\t[2] Kolla vad du rullade\n" +
                    "\t[3] Avsluta");
                Console.Write("\tVälj: ");
                int val;
                int.TryParse(Console.ReadLine(), out val);

                switch (val)
                {
                    case 1:
                        Console.Write("\n\tHur många tärningar vill du rulla: ");
                        bool inmatning = int.TryParse(Console.ReadLine(), out int antal);

                        if (inmatning)
                        {
                            for (int i = 0; i < antal; i++)
                            {
                                // här kallar vi på metoden RullaTärning
                                // och sparar det returnerade värdet i 
                                // listan tärningar

                                tärningar.Add(RullaTärning(slump));
                            }
                        }
                        break;
                    case 2:
                        int sum =0; // Skapar en int som ska innehålla medelvärdet av alla tärningsrullningar.

                        if (tärningar.Count <= 0)
                        {
                            Console.WriteLine("\n\tDet finns inga sparade tärningsrull! ");
                        }
                        else
                        {
                            foreach (int tärning in tärningar)// här metod för presentera medelvärdet
                            {
                                sum += tärning;
                            }
                           

                            Console.WriteLine("\n\tRullade tärningar: ");
                            foreach (int tärning in tärningar)
                            {
                                Console.WriteLine("\t" + tärning);
                            }
                            Console.WriteLine("\n\tMedelvärdet på alla tärningsrull: " + sum / tärningar.Count); // Här ska medelvärdet skrivas ut
                        }

                        break;
                    case 3:
                        Console.WriteLine("\n\tTack för att du rullade tärning!");
                        Thread.Sleep(1000);
                        kör = false;
                        break;
                    default:
                        Console.WriteLine("\n\tVälj 1-3 från menyn.");
                        break;
                }
            }
        }


    }
}
