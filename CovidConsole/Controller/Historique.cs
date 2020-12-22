using System;

namespace CovidConsole.Controller
{
    class Historique
    {
        protected DateTime time;

        public DateTime getTime()
        {
            return time;
        }

        public void setTime(int jour, int mois, int annee)
        {
            time = new DateTime(jour, mois, annee);
        }
    }

}
