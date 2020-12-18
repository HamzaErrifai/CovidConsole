using System;

namespace CovidConsole
{
    class Test
    {
        static public int idTest = 0;
        private Citoyen citoyen;
        private string type;
        /* 3 Types
         * virologique
         * sérologique 
         * none : "il n'a pas fait du test"
         * https://www.normandie.ars.sante.fr/coronavirus-covid-19-les-differents-types-de-tests#:~:text=Les%20tests%20virologiques%20(RT%2DPCR,et%20recommand%C3%A9%20pour%20le%20d%C3%A9pistage.
        */
        private DateTime date;
        private bool hasSymptoms;
        private string resultat; // Le status du citoyen

        public Test(Citoyen citoyen, DateTime date, string type, bool hasSymptoms)
        {
            idTest++;
            this.citoyen = citoyen;
            this.type = type;
            this.date = date;
            this.hasSymptoms = hasSymptoms;
            resultat = "inconnu";
        }

        public int getIdTest()
        {
            return idTest;
        }

        public Citoyen getCitoyen()
        {
            return citoyen;
        }

        public string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public bool getHasSymptoms()
        {
            return hasSymptoms;
        }

        public void setHasSymptoms(bool hasSymptoms)
        {
            this.hasSymptoms = hasSymptoms;
        }

        public string getResultat()
        {
            return resultat;
        }

        public void setResultat(string resultat)
        {
            this.resultat = resultat;
        }

        public void generateResultat()
        {
            if (this.hasSymptoms && citoyen.getAge() >= 60)
                setResultat("malade");
            else if (!this.hasSymptoms && citoyen.getAge() < 60)
                setResultat("suspect");
            else
            {
                citoyen.addVaccination("ARN Messager");
                setResultat("vaccine");
            }

        }

    }
}
