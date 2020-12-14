using System;

namespace CovidConsole
{
    class Vaccination : Historique
    {
        public string type{ get; set; }
        public Vaccination(string type)
        {
            time = DateTime.Now;
            this.type = type;
        }
    }
}
