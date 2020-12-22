using System;
using System.Data;
using CovidConsole.Controller;

namespace CovidConsole
{
    class Program
    {
        //TODO: add a view folder

        static void Main(string[] args)
        {
            Citoyen c1 = new Citoyen("cd666666", "Benabass", "Abass", "Homme", 5, 6, 1940);

            var people = Citoyen.getAll();
            showColorCode(people);

        }
        static void showColorCode(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                switch (row["codecouleur"])
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
                Console.WriteLine($"le code couleur de {row["prenom"]} {row["nom"]} est {row["codecouleur"]}");
                Console.ResetColor();
            }

        }

    }
}
