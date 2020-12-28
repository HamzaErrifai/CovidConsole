using System;
using System.Collections.Generic;
using System.Data;

namespace CovidConsole.Controller
{
    //TODO: Amélioration d'algorithme de verification + changement

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

        private Test()
        {
        }

        public Test(Citoyen citoyen, DateTime date, string type, bool hasSymptoms)
        {
            this.citoyen = citoyen;
            this.type = type;
            this.date = date;
            this.hasSymptoms = hasSymptoms;
            generateResultat();
            add(this.type, this.date, this.hasSymptoms, this.resultat, this.citoyen.getCin());
            this.citoyen.setStatus(this.resultat);
            this.citoyen.update<string>("codecouleur", this.citoyen.getCodeCouleur());
        }

        public void add(string type, DateTime date, bool hassymptoms, string resultat, string cinP)
        {
            this.addData(type, date, hassymptoms, resultat, cinP);
        }

        public List<Test> getAll(string cinC)
        {
            List<Test> lt = new List<Test>();
            foreach (DataRow row in getByCin(cinC).Rows)
            {
                Test temp = new Test();
                temp.idTest = (int)row["id"];
                temp.citoyen = Citoyen.get(row["cinC"].ToString());
                temp.type = row["type"].ToString();
                temp.resultat = row["resultat"].ToString();
                temp.date = ((DateTime)row["dateT"]);
                lt.Add(temp);
            }
            return lt;
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

        public DateTime getDate()
        {
            return date;
        }

        public bool getHasSymptoms()
        {
            return hasSymptoms;
        }

        public string getResultat()
        {
            return resultat;
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

        public void update<T>(string itemName, T itemValue)
        {
            UpdateByCin<T>(this.citoyen.getCin(), itemName, itemValue);
        }

        public void setType(string type)
        {
            this.type = type;
            update("typeT", type);
        }

        public void setDate(DateTime date)
        {
            this.date = date;
            update("dateT", date);
        }

        public void setHasSymptoms(bool hasSymptoms)
        {
            this.hasSymptoms = hasSymptoms;
            update("hassymptoms", (this.hasSymptoms ? 1 : 0));
        }


        public void setResultat(string resultat)
        {
            this.resultat = resultat;
        }


    }
}
