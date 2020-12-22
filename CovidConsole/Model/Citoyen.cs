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

        public DataTable addData(string cin, string nom, string prenom, string sexe, string codecouleur, string statusC, DateTime dateDeNaissance)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            conn.Open();
            command.CommandText = $"INSERT INTO {tableName} (cin, nom, prenom, sexe, codecouleur, statusC, dateDeNaissance)" +
                $"VALUES ({cin}, {nom}, {prenom}, {sexe}, {codecouleur}, {statusC}, {dateDeNaissance})";
            command.Prepare();
            command.ExecuteNonQuery();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
