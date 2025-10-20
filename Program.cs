using System;
using System.Collections.Generic;

class CinemaApp
{
    static List<string> seats = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3" };
    static List<string> bookedSeats = new List<string>();

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("🎬 Kinoticketsystem 🎟️");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Verfügbare Sitzplätze anzeigen");
            Console.WriteLine("2. Sitzplatz buchen");
            Console.WriteLine("3. Ticket drucken");
            Console.WriteLine("4. Beenden");
            Console.Write("Ihre Wahl: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowSeats();
                    break;
                case "2":
                    BookSeat();
                    break;
                case "3":
                    PrintTicket();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("❌ Ungültige Option, bitte erneut versuchen.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();
            }
        }
    }

    static void ShowSeats()
    {
        Console.WriteLine("Verfügbare Sitzplätze:");
        foreach (var seat in seats)
        {
            if (!bookedSeats.Contains(seat))
                Console.WriteLine(seat);
        }
    }

    static void BookSeat()
    {
        Console.Write("Welchen Sitzplatz möchten Sie buchen? ");
        string seatChoice = Console.ReadLine();
        if (seats.Contains(seatChoice) && !bookedSeats.Contains(seatChoice))
        {
            bookedSeats.Add(seatChoice);
            Console.WriteLine($"✅ Sitzplatz {seatChoice} erfolgreich gebucht!");
        }
        else
        {
            Console.WriteLine("❌ Sitzplatz ungültig oder bereits gebucht.");
        }
    }

    static void PrintTicket()
    {
        Console.WriteLine("Ihre gebuchten Tickets:");
        foreach (var seat in bookedSeats)
        {
            Console.WriteLine($"🎫 {seat} - Preis: 10€");
        }
    }
}
