using System;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Admin : Model
    {
        protected Admin()
        {
            tableName = "admins";
        }
        protected void addData(string username, string pwd)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            try
            {
                conn.Open();
                command.CommandText = $"INSERT INTO lieux (username, pwd)" +
                    $"VALUES ('{username}', '{pwd}')";
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
