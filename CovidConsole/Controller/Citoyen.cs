using System;
using System.Collections.Generic;
using System.Data;

namespace CovidConsole.Controller
{
    class Citoyen : Model.Citoyen
    {
        private string cin;
        private string nom;
        private string prenom;
        private string codeCouleur;
        private string sexe;
        private DateTime dateDeNaissance;
        private string status;
        private Test test;
        private List<Lieux> histLieux = new List<Lieux>();
        private List<Vaccination> histVaccination = new List<Vaccination>();

        private Citoyen()
        {
        }

        public Citoyen(string o_cin, string o_nom, string o_sexe, string o_prenom, int jour, int mois, int annee)
        {
            cin = o_cin;
            nom = o_nom;
            prenom = o_prenom;
            sexe = o_sexe;
            setdateDeNaissance(jour, mois, annee);
            status = "inconnu";
            //save data to db
            add(cin, nom, prenom, sexe, codeCouleur, status, dateDeNaissance);
        }

        public int getAge()
        {
            return DateTime.Today.Year - dateDeNaissance.Year;
        }

        public void add(string cin, string nom, string prenom, string sexe, string codecouleur, string statusC, DateTime dateDeNaissance)
        {
            try
            {
                this.addData(cin, nom, prenom, sexe, codeCouleur, status, dateDeNaissance);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static List<Citoyen> getAll()
        {
            Citoyen ct = new Citoyen();
            List<Citoyen> c = new List<Citoyen>();

            foreach (DataRow row in ct.getData().Rows)
            {
                Citoyen temp = new Citoyen();
                temp.cin = row["cin"].ToString();
                temp.nom = row["nom"].ToString();
                temp.prenom = row["prenom"].ToString();
                temp.status = row["statusC"].ToString();
                temp.codeCouleur = row["codecouleur"].ToString();
                temp.dateDeNaissance = ((DateTime)row["dateDeNaissance"]);
                c.Add(temp);
            }
            return c;
        }

        public static Citoyen get(string cin)
        {
            Citoyen c = new Citoyen();
            foreach (DataRow row in c.getByCin(cin).Rows)
            {
                Citoyen temp = new Citoyen();
                temp.cin = row["cin"].ToString();
                temp.nom = row["nom"].ToString();
                temp.prenom = row["prenom"].ToString();
                temp.status = row["statusC"].ToString();
                temp.codeCouleur = row["codecouleur"].ToString();
                temp.dateDeNaissance = ((DateTime)row["dateDeNaissance"]);
            }
            return c;
        }

        public string getCin()
        {
            return cin;
        }

        public string getSexe()
        {
            return sexe;
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

        public void update<T>(string itemName, T itemValue)
        {
            this.UpdateByCin<T>(cin, itemName, itemValue);
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
                case "mineur":
                case "guerri":
                case "vaccine":
                    codeCouleur = "vert";
                    break;
                default:
                    codeCouleur = "gris";
                    break;
            }
            update("codecouleur", codeCouleur);
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

        public void setTest(bool hasSymptoms, string type)
        {
            //si l'utilisateur appel cette methode donc le citoyen a fait un test
            test = new Test(this, DateTime.Now, type, hasSymptoms);
            generateStatusFromTest();
        }

        public void setStatus(string stat)
        {
            status = stat;
            generateCodeCouleur();
            update("statusC", status);
        }

        public void setdateDeNaissance(int jour, int mois, int annee)
        {
            dateDeNaissance = new DateTime(annee, mois, jour);
            update("dateDeNaissance", dateDeNaissance.ToString("MM/dd/yyyy HH:mm:ss"));
        }

        public void setNom(string nom)
        {
            this.nom = nom;
            update("nom", this.nom);
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
            update("prenom", this.prenom);
        }

        public void setCin(string cin)
        {
            this.cin = cin;
            update("cin", this.cin);
        }

        public void addLieu(double longitude, double latitude)
        {
            histLieux.Add(new Lieux(longitude, latitude, this.cin));
        }

        public void addVaccination(string type)
        {
            histVaccination.Add(new Vaccination(type));
        }

    }
}
