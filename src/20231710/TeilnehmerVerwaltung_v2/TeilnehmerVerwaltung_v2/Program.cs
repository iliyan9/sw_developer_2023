using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TeilnehmerVerwaltung_v2
{
    internal class Program
    {
        /*
            Implementieren Sie eine Applikation mit der beliebig viele Teilnehmerdaten erfasst und dargestellt werden können. Folgende Anforderung sollen dabei erfüllt werden:

             max.Anzahl der Teilnehmer soll zu Beginn vom User befragt werden
             Einlesen folgender Daten:
             Name, Vorname
             Geburtsdatum
             PLZ, Ort
             Fehlertolerante Eingaben
             verwenden sie Methoden wo sinnvoll
             verwenden sie Farben
             Teilnehmerdaten sollen nach der Eingabe tabellarisch ausgegeben werden
            *
            * */

        static void Main(string[] args)
        {
            Teilnehmer teilnehmer = new Teilnehmer();
            string headerText = "Teilnehmer Verwaltung v2";



            CreateHeader(headerText, ConsoleColor.Cyan, true);

            Console.WriteLine("Bitte geben Sie die Teilnehmer Daten ein: ");
            teilnehmer = GetStudentInfos();

            DisplayStudentInfo(teilnehmer);

        }

        private static Teilnehmer GetStudentInfos()
        {
            Teilnehmer teilnehmer;

            teilnehmer.Name = ReadString("\tVorname:");
            teilnehmer.Nachname = ReadString("\tNachname:");
            teilnehmer.Geburtsdatum = ReadDateTime("\tGeburtsdatum: ");
            teilnehmer.Plz = ReadInt("\tPLZ: ");
            teilnehmer.Ort = ReadString("\tWohnort:");

            return teilnehmer;
        }

        private static int ReadInt(string inputPrompt)
        {
            string input = string.Empty;
            int inputValue = 0;
            bool inputIsValid = false;
            do
            {
                Console.Write("\tGeburtsdatum (dd.mm.YYYY): ");
                input = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    inputValue = DateTime.Parse(input "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    inputIsValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\aERROR: Ungültige Eingabe.");
                    inputValue = 0;
                    Console.ResetColor();
                    inputIsValid = false;
                }

            }
            while (!inputIsValid);
        }

        private static void DisplayStudentInfo(Teilnehmer teilnehmerToDisplay)
        {
            Console.WriteLine("\nDie Teilnehmerdaten \n");

            Console.WriteLine($"\t{studentInfo)");
            do
            {
                Console.Write("\tGeburtsdatum (dd.mm.YYYY): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    geburtsdatum = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    inputIsValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\aERROR: Ungültige Datumseingabe.");
                    inputDateTime = DateTime.MinValue;
                    Console.ResetColor();
                    inputIsValid = false;
                }

            }
            while (!inputIsValid);

            return inputDateTime; ($"\t{vorname}, {name}, {geburtsdatum}, {plz}, {ort}")
        }

        private static string ReadString(string inputPrompt)
        {
            string input = string.Empty;

            do
            {

                Console.Write(inputPrompt);
                input = Console.ReadLine();

            }
            while (string.IsNullOrEmpty(input));

            return input;

        }

        private static DateTime ReadDateTime(string inputPrompt)
        {
            string input = string.Empty;
            DateTime inputDateTime = DateTime.MinValue;
            bool inputIsValid = false;
            do
            {
                Console.Write("\tGeburtsdatum (dd.mm.YYYY): ");
                input = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    inputDateTime = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    inputIsValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\aERROR: Ungültige Datumseingabe.");
                    inputDateTime = DateTime.MinValue;
                    Console.ResetColor();
                    inputIsValid = false;
                }

            }
            while (!inputIsValid);

            return inputDateTime;
        }


        private static void CreateHeader(string headerText, ConsoleColor headerTextColor, bool clearScreen)
        {
            int xTitelPos = 0;

            if (clearScreen)
            {
                Console.Clear();
            }

            //Darstellung Programm Header 
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            Console.WriteLine(new string('*', Console.WindowWidth - 1));

            //cursor f. Titel Ausgabe positionieren
            xTitelPos = (Console.WindowWidth - (headerText.Length + 2)) / 2;
            Console.SetCursorPosition(xTitelPos, 1);

            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = headerTextColor;
            Console.Write(" " + headerText + " ");
            Console.ForegroundColor = oldColor;

            //alte cursor Position wiederherstellen
            Console.SetCursorPosition(0, 4);
            //Consolen Fensterbezeichnung setzen
            Console.Title = headerText;
        }


    }
}
