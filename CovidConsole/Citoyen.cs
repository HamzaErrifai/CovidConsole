using System;
using System.Collections.Generic;

namespace CovidConsole
{
    class Citoyen
    {
        private string cin;
        private string nom;
        private string prenom;
        private string codeCouleur;
        private string sexe;
        private DateTime dateDeNaissance;
        private string status;
        private Test test;
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
            test = new Test(this, DateTime.Now, "none", false);
        }

        public int getAge()
        {
            return DateTime.Today.Year - dateDeNaissance.Year;
        }

        public string getSexe()
        {
            return sexe;
        }

        public void setStatus(string stat) // TODO: MAKE IT PRIVATE TO THE CLASS
        {
            status = stat;
            generateCodeCouleur();
        }

        public void generateStatusFromTest()
        {
            // set the status from the 
            setStatus(test.getResultat());
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
                case "Guerri":
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

        public List<Vaccination> getHistDeVaccination()
        {
            return histVaccination;
        }
        public List<Lieux> getHistDesLieux()
        {
            return histLieux;
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
