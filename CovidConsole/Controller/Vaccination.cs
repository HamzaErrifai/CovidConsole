using System;

namespace CovidConsole.Controller
{
    class Vaccination : Historique
    {
        public string type { get; set; }

        /*types de vaccins:
        * https://www.francetvinfo.fr/sante/maladie/coronavirus/vaccin/coronavirus-les-trois-types-de-vaccins_4206807.html
        * ARN Messager
        * Vecteur viral
        * sanofi
        */
        public Vaccination(string type)
        {
            time = DateTime.Now;
            this.type = type;
        }
    }
}
