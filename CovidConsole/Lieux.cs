using System;
namespace CovidConsole
{
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

    class Lieux : Historique
    {
        private double longitude;
        private double latitude;

        public Lieux(double o_longitude, double o_latitude)
        {
            time = DateTime.Now;
            setPosistion(o_longitude, o_latitude);
        }

        public void setPosistion(double o_longitude, double o_latitude)
        {
            longitude = o_longitude; //x
            latitude = o_latitude; //y
        }
        public Point getPosistion()
        {
            return new Point(longitude, latitude);
        }
    }
}
