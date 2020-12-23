using System;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    //TODO: add modification of lieux in citoyen
    class Lieux : Model
    {
        public Lieux()
        {
            tableName = "lieux";
        }

        protected void addData(string cinC, double longitude, double latitude, DateTime dateL)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            try
            {
                conn.Open();
                command.CommandText = $"INSERT INTO lieux (cinC, longitude, latitude, dateL)" +
                    $"VALUES ('{cinC}', '{longitude}', '{latitude}', '{dateL.ToString("MM/dd/yyyy HH:mm:ss")}')";
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
