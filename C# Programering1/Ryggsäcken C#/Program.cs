// Murtadha Alobaidi
using System;
namespace Ryggsäcken
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title för min arbeta för övning 2
            Console.Title = "Murtadha Alobaidi NTI skolan / Programering 1/ Övning 2";

            //för att upprepa menyen 
            bool Huvudmeny = true;
            string valEtt = "";
            while (Huvudmeny)
            {
                // Vällkomen till användarens
                Console.WriteLine("\n\tVälkommen till Rygsäcken!");
                //Liste på vad användarens kan väljea 
                Console.WriteLine("\t[1]Lägg till ett föremål");
                Console.WriteLine("\t[2]Skriv ut innehållet");
                Console.WriteLine("\t[3]Rensa innehållet");
                Console.WriteLine("\t[4]Asluta");
                Console.Write("\tVälj: ");

                // Vad användarens väljer 
                //int menyVal = Convert.ToInt32(Console.ReadLine());
                //Så att bogram inte krascha om du skriver fel
                Int32.TryParse(Console.ReadLine(), out int menyVal);//Så att pogram ska inte krasha

                //använda menyvalet med switch
                switch (menyVal)
                {
                    //användarens välja en föremål
                    case 1:
                        Console.Write(": ");
                        valEtt = Console.ReadLine();
                        break;

                    //skriver ut förmål
                    case 2:
                        Console.WriteLine(valEtt);
                        break;

                    //rensa innehållet
                    case 3:
                        valEtt = "";
                        break;

                    //avsluta programmet
                    case 4:
                        Huvudmeny = false;
                        break;


                }
            }
        }
    }
}

