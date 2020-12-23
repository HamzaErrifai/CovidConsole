using System;
using System.Collections.Generic;
using CovidConsole.Controller;

namespace CovidConsole
{
    class Program
    {
        //TODO: add a view folder

        static void Main(string[] args)
        {
            //This Class is just to test some components
            List<Citoyen> people = Citoyen.getAll();
            setTest(people);
            showColorCode(people);
            //setRandomPosition(people);
            showlieux(people[0]);
        }

        static void setRandomPosition(List<Citoyen> cs)
        {
            //Range from -90 to 90 for latitude and -180 to 180 for longitude.
            Random rndLat = new Random(); //Lattitude
            double MIN_LATITUDE_VALUE = -90;
            double MAX_LATITUDE_VALUE = 90;
            double MIN_LONGITUDE_VALUE = -180;
            double MAX_LONGITUDE_VALUE = 180;

            foreach (Citoyen c in cs)
            {
                double randomLat = rndLat.NextDouble() * (MAX_LATITUDE_VALUE - MIN_LATITUDE_VALUE) + MIN_LATITUDE_VALUE;
                double randomLon = rndLat.NextDouble() * (MAX_LONGITUDE_VALUE - MIN_LONGITUDE_VALUE) + MIN_LONGITUDE_VALUE;
                c.addLieu(randomLat, randomLon);
            }

        }

        static void setTest(List<Citoyen> cs)
        {
            //Just to test the program
            foreach (Citoyen c in cs)
            {
                if (c.getAge() >= 40 && c.getAge() < 60)
                    c.setTest(false, "virologique");
                else
                    c.setTest(true, "virologique");
            }
        }

        static void showlieux(Citoyen c)
        {
            foreach (Lieux l in c.getHistLieux())
            {
                if (l.getPosition() != null)
                    Console.WriteLine(l.getPosition());
            }
            Console.WriteLine("DONE");
        }

        static void showColorCode(List<Citoyen> cs)
        {
            foreach (Citoyen c in cs)
            {
                switch (c.getCodeCouleur())
                {
                    case "rouge":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "orange":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "vert":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.WriteLine($"le code couleur de {c.getFullName()} est {c.getCodeCouleur()}");
                Console.ResetColor();
            }

        }

    }
}
