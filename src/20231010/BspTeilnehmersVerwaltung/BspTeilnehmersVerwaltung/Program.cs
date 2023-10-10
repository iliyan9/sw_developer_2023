using System;
using System.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace BspTeilnehmersVerwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string vorname = string.Empty;
            DateTime geburtsDatum = DateTime.MinValue;
            string input = string.Empty;
            int xTitelPos = 16 - 95;

            string titel = " TeilnehmersVerwaltung ";
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            xTitelPos = (Console.WindowWidth - titel.Length) / 2;

            Console.SetCursorPosition (xTitelPos, 1);
            Console.Write("TeilnehmersVerwaltung");

            Console.SetCursorPosition(0, 3);
            Console.Title = "TeilnehmersVerwaltung";

            Console.WriteLine("\tHallo");

            Console.Write("\tVorname: ");
            vorname = Console.ReadLine();

            Console.Write("\tName: ");
            name = Console.ReadLine();

            Console.Write($"\tGeburtsDatum *dd-MM-yyyy: ");
            input = Console.ReadLine();
            geburtsDatum = DateTime.ParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            try
            {
                geburtsDatum = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("\aERROR: Ungultige Datum/Eingabe.");
                geburtsDatum = DateTime.MinValue;
            }

            if(geburtsDatum.Year != DateTime.MinValue.Year) 
            {
                int alter = DateTime.Now.Year - geburtsDatum.Year;
                if (alter >= 16 && alter <= 95);
                {
                    Console.WriteLine("Error: \a Leider ist der Teilnehmer ausserhalb des gultigen Alter!");
                    return;
                }

                Console.WriteLine($"\nTeilnehmerdaten:\n ");
                Console.WriteLine($"\tVorname: {vorname}");
                Console.WriteLine($"\name: {name}");













        }
    }
}
