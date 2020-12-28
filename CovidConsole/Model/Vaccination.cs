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
                    $"VALUES ('{cinC}', '{type}', '{dateV}')";
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
