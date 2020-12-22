﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Citoyen : Model
    {
        public Citoyen()
        {
            tableName = "citoyen";
        }

        protected void addData(string cin, string nom, string prenom, string sexe, string codecouleur, string statusC, DateTime dateDeNaissance)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            try
            {
                conn.Open();
                command.CommandText = $"INSERT INTO {tableName} (cin, nom, prenom, sexe, codecouleur, statusC, dateDeNaissance)" +
                    $"VALUES ('{cin}', '{nom}', '{prenom}', '{sexe}', '{codecouleur}', '{statusC}', '{dateDeNaissance}')";
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                if (e.Number == 2627) //Violation of primary key
                {
                    throw new Exception("Ce citoyen existe déja");
                }
                else
                    throw;
            }

        }
    }
}
