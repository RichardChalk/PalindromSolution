using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Här är några exempel på palindrom
            // Radar
            // Noon
            // Level
            // Kayak


            Console.Write("Skriv in ett ord eller en fras: ");
            string input = Console.ReadLine();

            // Ändra variablenamn från Svenska! USCH!
            // VS kan hjälpa till! :)
            string renadInput = TaBortMellanslagOchSkiljetecken(input.ToLower());

            if (ÄrPalindrom(renadInput))
            {
                Console.WriteLine("Det är ett palindrom!");
            }
            else
            {
                Console.WriteLine("Det är inte ett palindrom.");
            }
        }

        // Main slutar här! ===============================================




        // Dessa metoder nedanför har vi skapat själva! ===================
        /// <summary>
        /// Rensa en sträng av samtliga whitespace tecken
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string TaBortMellanslagOchSkiljetecken(string text)
        {
            string renad = "";
            foreach (char tecken in text)
            {
                if (char.IsLetterOrDigit(tecken)) // Endast bokstäver och siffror behålls
                {
                    renad += tecken;
                }
            }
            return renad;
        }

        /// <summary>
        /// Kontrollerar om ett ord är en palindrom
        /// Returnerar sant eller falskt
        /// Exempel: Om vi har strängen "radar":
        /// Första loopen(i = 0): text[0] är "r" och text[4] är också "r" (sista tecknet).
        /// Andra loopen(i = 1): text[1] är "a" och text[3] är också "a" (näst sista tecknet).
        /// Vi fortsätter tills vi nått mitten.Om alla tecken matchar, vet vi att strängen är ett palindrom.
        /// Om något tecken inte stämmer överens, så är det inte ett palindrom, och programmet avslutar direkt med return false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static bool ÄrPalindrom(string text)
        {
            int längd = text.Length;

            for (int i = 0; i < längd / 2; i++)
            {
                if (text[i] != text[längd - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
