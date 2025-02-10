using System;
using System.Collections.Generic;

namespace CustomGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Spør brukeren om navn
            Console.Write("Skriv inn navnet ditt: ");
            string navn = Console.ReadLine();

            // Hent den nåværende timen
            int currentHour = DateTime.Now.Hour;

            // Opprett et dictionary som oppslagsbord for hilsener
            Dictionary<string, string> greetings = new Dictionary<string, string>()
            {
                {"Night", "God natt"},
                {"Morning", "God morgen"},
                {"Afternoon", "God ettermiddag"},
                {"Evening", "God kveld"}
            };

            // Bestem hvilken hilsen som skal brukes basert på time
            string greetingKey;
            if (currentHour < 6)
                greetingKey = "Night";
            else if (currentHour < 12)
                greetingKey = "Morning";
            else if (currentHour < 18)
                greetingKey = "Afternoon";
            else
                greetingKey = "Evening";

            // Hent hilsningsmeldingen fra dictionaryen
            string greetingMessage = greetings[greetingKey];

            // Skriv ut hilsningen til brukeren
            Console.WriteLine($"{greetingMessage}, {navn}!");

            // Hold konsolvinduet åpent
            Console.ReadLine();
        }
    }
}
