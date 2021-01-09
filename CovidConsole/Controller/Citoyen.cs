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
        private Lieux histLieux = new Lieux();
        private Vaccination histVaccination = new Vaccination();
        public static List<string> possibleStatus { get; } = new List<string> { "", "inconnu", "malade", "suspect", "guerri", "bonne sante" };
        public static List<string> possibleSexe { get; } = new List<string> { "", "Homme", "Femme" };

        private Citoyen()
        {
        }

        public Citoyen(string o_cin, string o_nom, string o_prenom, string o_sexe, int jour, int mois, int annee)
        {
            cin = o_cin;
            nom = o_nom;
            prenom = o_prenom;
            sexe = o_sexe;
            setdateDeNaissance(jour, mois, annee);
            status = "inconnu";
            generateCodeCouleur();
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
                this.addData(cin, nom, prenom, sexe, codecouleur, statusC, dateDeNaissance);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void delete()
        {
            deleteById(this.cin);
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
                temp.sexe = row["sexe"].ToString();
                temp.codeCouleur = row["codecouleur"].ToString();
                temp.dateDeNaissance = ((DateTime)row["dateDeNaissance"]);
                c.Add(temp);
            }
            return c;
        }
        public static Citoyen get(string cin)
        {
            Citoyen c = new Citoyen();
            DataTable dt = c.getByCin(cin);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Citoyen temp = new Citoyen();
                temp.cin = row["cin"].ToString();
                temp.nom = row["nom"].ToString();
                temp.prenom = row["prenom"].ToString();
                temp.sexe = row["sexe"].ToString();
                temp.status = row["statusC"].ToString();
                temp.codeCouleur = row["codecouleur"].ToString();
                temp.dateDeNaissance = ((DateTime)row["dateDeNaissance"]);
                return temp;
            }
            return null;

        }

        public string getCin()
        {
            return cin;
        }

        public string getPrenom()
        {
            return prenom;
        }
        public string getNom()
        {
            return nom;
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
        public string _cin
        {
            get
            {
                return cin;
            }
        }

        public string getFullName()
        {
            return prenom + " " + nom;
        }

        public void update<T>(string itemName, T itemValue)
        {
            UpdateByCin(cin, itemName, itemValue);
        }
        public DateTime getdateDeNaissance()
        {
            return dateDeNaissance;
        }

        public static string getColorByStatus(string stat)
        {
            switch (stat.ToLower())
            {
                case "malade":
                    return "red";
                case "suspect":
                    return "orange";
                case "guerri":
                case "bonne sante":
                    return "green";
                default:
                    break;
            }
            return "gray";
        }

        public void generateCodeCouleur()
        {
            getColorByStatus(status);
            update("codecouleur", codeCouleur);
        }

        public string getCodeCouleur()
        {
            return codeCouleur;
        }

        public List<Vaccination> getHistDeVaccination()
        {
            return histVaccination.getAll(cin);
        }

        public List<Lieux> getHistLieux()
        {
            return histLieux.getAll(cin);
        }

        public void setTest(string type, bool hasSymptoms)
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
            update("dateDeNaissance", dateDeNaissance);
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

        public void addLieu(double latitude, double longitude)
        {
            histLieux = new Lieux(latitude, longitude, this.cin);
        }

        public void addVaccination(string type)
        {
            histVaccination = new Vaccination(type, cin);
        }

        public void updateAll(string cin, string nom, string prenom, string sexe, string codecouleur, string statusC, DateTime dateDeNaissance)
        {
            update("cin", cin);
            update("nom", nom);
            update("prenom", prenom);
            update("sexe", sexe);
            update("codecouleur", codecouleur);
            update("statusC", statusC);
            update("dateDeNaissance", dateDeNaissance);
        }
    }
}
