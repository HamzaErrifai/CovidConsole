using System;
using System.Collections.Generic;

namespace CovidConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Citoyen c1 = new Citoyen("cd666666", "Benabass", "Abass", "Homme", 5, 6, 1940);
            Citoyen c2 = new Citoyen("cd888069", "Sebak", "Saida", "Femme", 5, 6, 1950);
            Citoyen c3 = new Citoyen("cd751050", "Khadoji", "Fatiha", "Femme", 5, 6, 1955);
            Citoyen c4 = new Citoyen("cd956616", "Sebak", "Khalid", "Homme", 5, 6, 1952);
            Citoyen c5 = new Citoyen("cd411229", "saidi", "Lamiae", "Femme", 5, 8, 1975);
            Citoyen c6 = new Citoyen("cd999324", "Hamzaui", "Mohammed", "Homme", 5, 6, 1970);
            Citoyen c7 = new Citoyen("cd717717", "Kriksh", "karim", "Homme", 5, 7, 1999);
            Citoyen c8 = new Citoyen("cd666262", "Gherbal", "Amine", "Homme", 5, 9, 2003);
            Citoyen c9 = new Citoyen("cd002211", "Karimi", "Malika", "Femme", 5, 1, 2005);
            Citoyen c10 = new Citoyen("cd05544", "Kacimi", "Zineb", "Femme", 5, 6, 1999);

            List<Citoyen> listCitoyens = new List<Citoyen> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };

            /*
             * le test est basé sur le type de test et l'age du citoyen
             **/

            //les citoyens malades
            c1.setTest(true, "virologique");
            c2.setTest(true, "sérologique");
            c3.setTest(true, "sérologique");
            c4.setTest(true, "sérologique");
            //les citoyens suspects
            c5.setTest(false, "virologique");
            c6.setTest(false, "virologique");
            //les citoyens en bonne santé
            c7.setTest(false, "virologique");
            c8.setTest(false, "virologique");
            c9.setTest(false, "virologique");
            c10.setTest(false, "virologique");

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
                        Console.ForegroundColor = ConsoleColor.Yellow;
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
