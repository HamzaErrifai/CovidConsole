using System;
using System.Collections.Generic;
using System.Data;
using CovidConsole.Controller;

namespace CovidConsole
{
    class Program
    {
        //TODO: add a view folder

        static void Main(string[] args)
        {
            List<Citoyen> people = Citoyen.getAll();
            setTest(people);
            showColorCode(people);
        }

        static void setTest(List<Citoyen> cs)
        {
            //Just to test the program
            foreach (Citoyen c in cs)
            {
                c.setTest(true, "virologique");
            }
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
