using System;
using System.Collections.Generic;
using System.Data;

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
        private string type;
        private DateTime dateV;
        private string cinC;

        public Vaccination()
        {}

        public Vaccination(string type, string cinC)
        {
            dateV = DateTime.Now;
            this.type = type;
            this.cinC = cinC;
            this.addData(this.cinC, this.type, dateV);
        }


        public void update<T>(string itemName, T itemValue)
        {
            this.UpdateByCin<T>(cinC, itemName, itemValue);
        }

        public DateTime getTime()
        {
            return dateV;
        }

        public void setTime(int jour, int mois, int annee)
        {
            dateV = new DateTime(jour, mois, annee);
            update<string>("dateV", dateV.ToString("MM/dd/yyyy HH:mm:ss"));
        }

        public void setType(string type)
        {
            this.type = type;
            update<string>("typeV", this.type);
        }
        public string getType()
        {
            return type;
        }

        public List<Vaccination> getAll(string cinC)
        {
            List<Vaccination> lt = new List<Vaccination>();
            foreach (DataRow row in getByCin(cinC).Rows)
            {
                Vaccination temp = new Vaccination();
                temp.cinC = row["cinC"].ToString();
                temp.type = row["typeV"].ToString();
                temp.dateV = ((DateTime)row["dateV"]);
                lt.Add(temp);
            }
            return lt;
        }

    }
}
