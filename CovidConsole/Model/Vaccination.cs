using System;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Vaccination : Model
    {
        protected Vaccination()
        {
            tableName = "vaccination";
        }

        protected void addData(string cinC, string type, DateTime dateV)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            try
            {
                conn.Open();
                command.CommandText = $"INSERT INTO vaccination (cinC, typeV, dateV)" +
                    $"VALUES ('{cinC}', '{type}', '{dateV.ToString("MM/dd/yyyy HH:mm:ss")}')";
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
