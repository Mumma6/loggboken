using System;
using System.Collections.Generic;

namespace Exercise6
{
  class Program
  {
    static void Main()
    {
      /* APP INFO */
      /////////////////////
      string appName = "Övning 7 - Loogboken.";
      string appVersion = "1.0.0";
      string autor = "Martin Persson";

      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("{0} Version: {1} by {2} \n", appName, appVersion, autor);
      Console.ResetColor();
      /////////////////////
      /* APP INFO */

      // Skapa en ny list som tar in string vektorer
      List<string[]> loggBok = new List<string[]> { };

      // isRunning ser till att programet körs sålänge den är satt till true
      bool isRunning = true;
      while (isRunning)
      {
        Console.WriteLine("\n\tVälkommen till loggboken!");
        Console.WriteLine("\t[1]Skriv ett inlägg: ");
        Console.WriteLine("\t[2]Skriv ut alla inlägg");
        Console.WriteLine("\t[3]Sök inlägg");
        Console.WriteLine("\t[4]Avsluta programmet!");
        Console.Write("\nVälj meny: ");

        // Användaren ger ett menu val
        int val;
        int.TryParse(Console.ReadLine(), out val);

        switch (val)
        {
          case 1:
            Console.WriteLine("Skriv en titel till din logg: ");
            // Skapar en ny vektor
            string[] post = new string[2];
            post[0] = Console.ReadLine();
            Console.WriteLine("Skriv ett meddelande: ");
            post[1] = Console.ReadLine();
            // Lägger till den nya vektorn i listan
            loggBok.Add(post);
            break;
          case 2:
            Console.WriteLine("Här är dina inlägg i loggboken: ");
            // Loopar igenom loggBok listan och skriver ut alla värden i consolen
            foreach (string[] text in loggBok)
            {
              Console.WriteLine("Inlägg: {0} " + "\n\t{1}", text[0], text[1]);
            }
            break;
          case 3:
            Console.WriteLine("Skriv in ett ord för att söka bland dina inlägg");
            // Får ett keyword från användaren
            string keyword = Console.ReadLine();
            foreach (string[] text in loggBok)
            {
              // Kollar ifall keyword finns med i listan, antingen som Title eller meddelande
              if (text[0].ToLower() == keyword.ToLower() || text[1].ToLower() == keyword.ToLower())
              {
                Console.Write("\nTitel: " + text[0] + "\n" + text[1]);
              }
            }
            break;
          case 4:
            // Avslutar programmet
            isRunning = false;
            break;
          // Om användaren inte skriver ett godkänt val i menyn så kommer detta fel meddelande upp.
          default:
            Console.WriteLine("\n\tVälj 1-4 från menyn.");
            break;
        }
      }
    }
  }
}
