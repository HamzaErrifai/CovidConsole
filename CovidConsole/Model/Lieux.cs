using System;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Lieux : Model
    {
        protected Lieux()
        {
            tableName = "lieux";
        }

        protected void addData(string cinC, double longitude, double latitude, DateTime dateL)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            try
            {
                string longitudeStr = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}", longitude);
                string latitudeStr = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}", latitude);

                conn.Open();
                command.CommandText = $"INSERT INTO lieux (cinC, longitude, latitude, dateL)" +
                    $"VALUES ('{cinC}', {longitudeStr}, {latitudeStr}, '{dateL}')";
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
