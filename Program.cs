using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        List<string> sitze = new List<string> { "A1", "A2", "A3", "A4", "A5" };
        List<string> gebuchteSitze = new List<string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("🎬 Kinoticket-Buchungssystem 🎟️");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Verfügbare Sitzplätze anzeigen");
            Console.WriteLine("2. Sitzplatz buchen");
            Console.WriteLine("3. Ticket drucken");
            Console.WriteLine("4. Beenden");
            Console.Write("Ihre Auswahl: ");
            string wahl = Console.ReadLine();

            switch (wahl)
            {
                case "1":
                    ZeigeVerfuegbareSitze(sitze, gebuchteSitze);
                    break;
                case "2":
                    BucheSitz(sitze, gebuchteSitze);
                    break;
                case "3":
                    DruckeTicket(gebuchteSitze);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("❌ Ungültige Auswahl — bitte erneut versuchen!");
                    break;
            }

            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
        }
    }

    static void ZeigeVerfuegbareSitze(List<string> sitze, List<string> gebuchteSitze)
    {
        Console.WriteLine("\n🪑 Verfügbare Sitzplätze:");
        foreach (var sitz in sitze)
        {
            if (!gebuchteSitze.Contains(sitz))
                Console.Write(sitz + " ");
        }
        Console.WriteLine();
    }

    static void BucheSitz(List<string> sitze, List<string> gebuchteSitze)
    {
        Console.Write("\nGeben Sie den Sitzplatz ein, den Sie buchen möchten (z.B. A3): ");
        string sitzwahl = Console.ReadLine();

        if (sitze.Contains(sitzwahl) && !gebuchteSitze.Contains(sitzwahl))
        {
            gebuchteSitze.Add(sitzwahl);
            Console.WriteLine($"✅ Sitzplatz {sitzwahl} erfolgreich gebucht!");
        }
        else
        {
            Console.WriteLine("❌ Sitzplatz ist nicht verfügbar oder existiert nicht.");
        }
    }

    static void DruckeTicket(List<string> gebuchteSitze)
    {
        if (gebuchteSitze.Count == 0)
        {
            Console.WriteLine("⚠️ Es wurden noch keine Sitzplätze gebucht!");
            return;
        }

        Console.WriteLine("\n🎫 Gebuchte Tickets:");
        foreach (var sitz in gebuchteSitze)
        {
            Console.WriteLine($"- Sitzplatz {sitz}");
        }
    }
}
