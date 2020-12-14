using System;
using System.Collections.Generic;
using System.Text;

namespace CovidConsole
{
    class Citoyen
    {
        private string cin { get; set; }
        private string nom;
        private string prenom;
        private string codeCouleur;
        private string sexe { get; set; }
        private DateTime dateDeNaissance;
        private string status;


        private List<Lieux> histLieux;
        private List<Vaccination> histVaccination;

        public Citoyen(string o_cin, string o_nom, string o_sexe, string o_prenom, int jour, int mois, int annee)
        {
            cin = o_cin;
            nom = o_nom;
            prenom = o_prenom;
            sexe = o_sexe;
            setdateDeNaissance(jour, mois, annee);
            setStatus("inconnu");
            histLieux = new List<Lieux>();
            histVaccination = new List<Vaccination>();
        }

        public int getAge()
        {
            return DateTime.Today.Year - dateDeNaissance.Year;
        }

        public void setStatus(string stat)
        {
            status = stat;
            generateCodeCouleur();
        }

        public string getstatus()
        {
            return char.ToUpper(status[0]) + status.Substring(1);
        }

        public string getFullName()
        {
            return prenom + " " + nom;
        }

        public void setdateDeNaissance(int jour, int mois, int annee)
        {
            dateDeNaissance = new DateTime(annee, mois, jour);
        }

        public DateTime getdateDeNaissance()
        {
            return dateDeNaissance;
        }

        public void generateCodeCouleur()
        {

            switch (status.ToLower())
            {
                case "malade":
                    codeCouleur = "rouge";
                    break;
                case "suspect":
                    codeCouleur = "orange";
                    break;
                case "Gueris":
                case "vaccine":
                    codeCouleur = "vert";
                    break;
                default:
                    codeCouleur = "gris";
                    break;
            }
        }

        public string getCodeCouleur()
        {
            return codeCouleur;
        }

        public void addLieu(double longitude, double latitude)
        {
            histLieux.Add(new Lieux(longitude, latitude));
        }

        public void addVaccination(string type)
        {
            histVaccination.Add(new Vaccination(type));
        }

    }
}
