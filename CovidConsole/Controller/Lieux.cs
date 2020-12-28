using System;
using System.Collections.Generic;
using System.Data;

namespace CovidConsole.Controller
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point(double ox, double oy)
        {
            x = ox;
            y = oy;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    class Lieux : Model.Lieux
    {
        private double longitude;
        private double latitude;
        private DateTime dateL;
        private string cinC;

        public Lieux() { }

        public Lieux(double o_latitude, double o_longitude, string cinC)
        {
            dateL = DateTime.Now;
            this.cinC = cinC;
            setPosition(o_latitude, o_longitude);
            addData(this.cinC, longitude, latitude, dateL);
        }

        public DateTime getTime()
        {
            return dateL;
        }

        public void setDateL(int jour, int mois, int annee)
        {
            dateL = new DateTime(jour, mois, annee);
            update("dateL", dateL);
        }

        public void setPosition(double o_latitude, double o_longitude)
        {
            longitude = o_longitude; //x
            latitude = o_latitude; //y
            update("longitude", longitude);
            update("latitude", latitude);
        }

        public void update<T>(string itemName, T itemValue)
        {
            UpdateByCin(cinC, itemName, itemValue);
        }

        public List<Lieux> getAll(string cinC)
        {
            List<Lieux> lt = new List<Lieux>();
            foreach (DataRow row in getByCin(cinC).Rows)
            {
                Lieux temp = new Lieux();
                temp.cinC = row["cinC"].ToString();
                temp.latitude = (double)row["latitude"];
                temp.longitude = (double)row["longitude"];
                temp.dateL = ((DateTime)row["dateL"]);
                lt.Add(temp);
            }
            return lt;
        }

        public Point getPosition()
        {
            return new Point(longitude, latitude);
        }
    }
}
