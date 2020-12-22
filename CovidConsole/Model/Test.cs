using System;
using System.Data;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Test : Model
    {
        protected void addData(string typeT, DateTime dateT, bool hassymptoms, string resultat, string cinC)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            try
            {
                conn.Open();
                command.CommandText = $"INSERT INTO {tableName} (typeT, dateT, hassymptoms, resultat, cinC)" +
                    $"VALUES ('{typeT}', '{dateT}', {hassymptoms}, '{resultat}', '{cinC}')";
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

        protected DataTable getById(int idItem)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            conn.Open();
            command.CommandText = $"SELECT * FROM {tableName} WHERE id = {idItem}";
            command.Prepare();
            command.ExecuteNonQuery();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
