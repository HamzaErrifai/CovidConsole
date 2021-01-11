using System;
using System.Collections.Generic;
using System.Data;

namespace CovidConsole.Controller
{
    class Vaccination : Model.Vaccination
    {
        public static List<string> possibleTypes { get; } = new List<string> { "", "ARN Messager", "Vecteur viral", "sanofi" };
        private int id;
        private string type;
        private string cinC;
        private DateTime dateV;

        public Vaccination()
        {}

        public Vaccination(string cinC, string type)
        {
            dateV = DateTime.Now;
            this.type = type;
            this.cinC = cinC;
            add(this.cinC, this.type);
        }

        public void add(string cinC, string type)
        {
            addData(this.cinC, this.type, DateTime.Now);
        }

        public void update<T>(string itemName, T itemValue)
        {
            UpdateByCin(cinC, itemName, itemValue);
        }

        public DateTime getDate()
        {
            return dateV;
        }

        public void setDate(int jour, int mois, int annee)
        {
            dateV = new DateTime(jour, mois, annee);
            update("dateV", dateV);
        }

        public void setType(string type)
        {
            this.type = type;
            update("typeV", this.type);
        }
        public string getType()
        {
            return type;
        }
        public int getId()
        {
            return id;
        }

        public static List<Vaccination> getAll(string cinC)
        {
            List<Vaccination> lt = new List<Vaccination>();
            Vaccination v = new Vaccination();
            foreach (DataRow row in v.getByCin(cinC).Rows)
            {
                Vaccination temp = new Vaccination();
                temp.id = (int)row["id"];
                temp.cinC = row["cinC"].ToString();
                temp.type = row["typeV"].ToString();
                temp.dateV = ((DateTime)row["dateV"]);
                lt.Add(temp);
            }
            return lt;
        }

        public void delete()
        {
            deleteById(id);
        }

        public void updateAll(string type)
        {
            update("typeV", type);
        }

        public int _id
        {
            get
            {
                return id;
            }
        }

    }
}
