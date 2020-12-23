using System;

namespace CovidConsole.Controller
{
    class Vaccination : Model.Vaccination
    {
        /*types de vaccins:
        * https://www.francetvinfo.fr/sante/maladie/coronavirus/vaccin/coronavirus-les-trois-types-de-vaccins_4206807.html
        * ARN Messager
        * Vecteur viral
        * sanofi
        */
        //TODO: getter and setter to type
        public string type { get; set; }
        protected DateTime dateV;

        public DateTime getTime()
        {
            return dateV;
        }

        public void setTime(int jour, int mois, int annee)
        {
            dateV = new DateTime(jour, mois, annee);
        }

        public Vaccination(string type)
        {
            dateV = DateTime.Now;
            this.type = type;
        }
    }
}
