using System;
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

        /*
         * idItem  : valeur de l'id
         * @return datatable
         * **/
        protected DataTable getById(string idItem)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            conn.Open();
            command.CommandText = $"SELECT * FROM {tableName} WHERE cin = {idItem}";
            command.Prepare();
            command.ExecuteNonQuery();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        /*
         * itemName  : field name in db 
         * itemValue : value that user want to change
         * **/

        protected void UpdateItem(string idItem, string itemName, string itemValue)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);

            conn.Open();
            command.CommandText = $"UPDATE {tableName} SET {itemName} = '{itemValue}' WHERE cin = '{idItem}'";
            command.Prepare();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
