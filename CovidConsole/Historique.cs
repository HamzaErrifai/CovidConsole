using System;
using System.Collections.Generic;
using System.Text;

namespace CovidConsole
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
