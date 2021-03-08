//Murtadha Alobaidi
using System;
namespace Felsökning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title för min arbeta för övning 2
            Console.Title = "Murtadha Alobaidi NTI skolan / Programering 1/ Övning 4";

            //Först jag har felsökat koden 
            //Jag felsökat med hjälp av debug verktygen  

            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            // Jag skriv metoden för att skapa slumptal mellan 1 och 21 
            int speltal = slumpat.Next(1, 21); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20

           bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras

            // ! Utropstecknet gör att loopen försätter så länge spela är falsk och inte sann
            while (spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                //Om användaren skriver in en bokstav istället så programmet inte kraschar  
                Int32.TryParse(Console.ReadLine(), out int tal);

                if (tal < speltal )
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                if (tal > speltal)
                {
                    //Söknas + 
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                }
                
                   //Söknas =
                if (tal == speltal)
                   // Söknas Klammerparenteser
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = false;
                }

            }







        }
    }
}
