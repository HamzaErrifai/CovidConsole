using System;
using System.Collections.Generic;

namespace CovidConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Citoyen c1 = new Citoyen("cd666666", "Benabass", "Abass", "Homme", 5, 6, 1999);
            Citoyen c2 = new Citoyen("cd888069", "Sebak", "Saida", "Femme", 5, 6, 1999);
            Citoyen c3 = new Citoyen("cd751050", "Khadoji", "Fatiha", "Femme", 5, 6, 1999);
            Citoyen c4 = new Citoyen("cd956616", "Sebak", "Khalid", "Homme", 5, 6, 1999);
            Citoyen c5 = new Citoyen("cd411229", "saidi", "Lamiae", "Femme", 5, 8, 1999);
            Citoyen c6 = new Citoyen("cd999324", "Hamzaui", "Mohammed", "Homme", 5, 6, 1999);
            Citoyen c7 = new Citoyen("cd717717", "Kriksh", "karim", "Homme", 5, 7, 1999);
            Citoyen c8 = new Citoyen("cd666262", "Gherbal", "Amine", "Homme", 5, 9, 1999);
            Citoyen c9 = new Citoyen("cd002211", "Karimi", "Malika", "Femme", 5, 1, 1999);
            Citoyen c10 = new Citoyen("cd05544", "Kacimi", "Zineb", "Femme", 5, 6, 1999);

            List<Citoyen> listCitoyens = new List<Citoyen> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };

            //les citoyens malades
            c1.setStatus("malade");
            c2.setStatus("malade");
            c3.setStatus("malade");
            c4.setStatus("malade");
            //les citoyens suspects
            c5.setStatus("suspect");
            c6.setStatus("suspect");
            //les citoyens en bonne santé
            c7.setStatus("vaccine");
            c8.setStatus("vaccine");
            c9.setStatus("vaccine");
            c10.setStatus("vaccine");

            showColorCode(listCitoyens);

        }
        static void showColorCode(List<Citoyen> ls)
        {
            foreach (Citoyen citoyen in ls)
            {
                switch (citoyen.getCodeCouleur())
                {
                    case "rouge":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "orange":
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        break;
                    case "vert":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.WriteLine($"le code couleur de {citoyen.getFullName()} est {citoyen.getCodeCouleur()}");
                Console.ResetColor();
            }

        }

    }
}
