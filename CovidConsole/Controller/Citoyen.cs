﻿using System;
using System.Collections.Generic;

namespace CovidConsole.Controller
{
    //TODO: setters should modify the database
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
        private List<Lieux> histLieux;
        private List<Vaccination> histVaccination;
        private string idName = "cin";

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
            histLieux = new List<Lieux>();
            histVaccination = new List<Vaccination>();
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
        public void get()
        {
            this.getData();
        }

        public string getSexe()
        {
            return sexe;
        }

        public void setTest(bool hasSymptoms, string type)
        {
            //si l'utilisateur appel cette methode donc le citoyen a fait un test
            test = new Test(this, DateTime.Now, type, hasSymptoms);
            generateStatusFromTest();
        }

        private void setStatus(string stat)
        {
            status = stat;
            generateCodeCouleur();
            update("statusC", status);
        }

        public void setdateDeNaissance(int jour, int mois, int annee)
        {
            dateDeNaissance = new DateTime(annee, mois, jour);
            update("dateDeNaissance", dateDeNaissance.ToString());
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

        public void update(string itemName, string itemValue)
        {
            this.UpdateItem(idName, this.cin, itemName, itemValue);
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
