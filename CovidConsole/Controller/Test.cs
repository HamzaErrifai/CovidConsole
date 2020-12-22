using System;
using System.Data;

namespace CovidConsole.Controller
{
    //TODO: Amélioration d'algorithme de verification + changement
    //TODO: get from DB


    class Test : Model.Test
    {
        /* 3 Types
         * virologique
         * sérologique 
         * none : "il n'a pas fait du test"
         * https://www.normandie.ars.sante.fr/coronavirus-covid-19-les-differents-types-de-tests#:~:text=Les%20tests%20virologiques%20(RT%2DPCR,et%20recommand%C3%A9%20pour%20le%20d%C3%A9pistage.
        */
        private int idTest;
        private Citoyen citoyen;
        private string type;
        private DateTime date;
        private bool hasSymptoms;
        private string resultat; // Le status du citoyen

        public Test(Citoyen citoyen, DateTime date, string type, bool hasSymptoms)
        {
            this.citoyen = citoyen;
            this.type = type;
            this.date = date;
            this.hasSymptoms = hasSymptoms;
            generateResultat();
            this.add(this.type, this.date, this.hasSymptoms, this.resultat, this.citoyen.getCin());
        }

        public void add(string type, DateTime date, bool hassymptoms, string  resultat, string cinP)
        {
            this.addData(type, date, hassymptoms, resultat, cinP);
        }

        public static DataTable getAll()
        {
            return Test.getData();
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
            else if (!this.hasSymptoms && citoyen.getAge() < 60 && citoyen.getAge() >= 40)
                setResultat("suspect");
            else if (citoyen.getAge() <= 15)
                setResultat("mineur");
            else
            {
                citoyen.addVaccination("ARN Messager");
                setResultat("vaccine");
            }

        }

    }
}
