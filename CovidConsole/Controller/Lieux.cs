using System;

namespace CovidConsole.Controller
{
    //TODO: add get list of Lieux by CIN
    class Point
    {
        double x { get; set; }
        double y { get; set; }

        public Point(double ox, double oy)
        {
            x = ox;
            y = oy;
        }
    }

    class Lieux : Model.Lieux
    {
        private double longitude;
        private double latitude;
        protected DateTime dateL;
        private string cinC;

        public Lieux(double o_longitude, double o_latitude, string cinC)
        {
            dateL = DateTime.Now;
            this.cinC = cinC;
            setPosistion(o_longitude, o_latitude);
            this.addData(cinC, longitude, latitude, dateL);
        }

        public DateTime getTime()
        {
            return dateL;
        }

        public void setDateL(int jour, int mois, int annee)
        {
            dateL = new DateTime(jour, mois, annee);
            update<string>("dateL", dateL.ToString("MM/dd/yyyy HH:mm:ss"));
        }

        public void setPosistion(double o_longitude, double o_latitude)
        {
            longitude = o_longitude; //x
            latitude = o_latitude; //y
            update<double>("longitude", longitude);
            update<double>("latitude", latitude);
        }

        public void update<T>(string itemName, T itemValue)
        {
            this.UpdateByCin<T>(cinC, itemName, itemValue);
        }

        public Point getPosistion()
        {
            return new Point(longitude, latitude);
        }
    }
}
