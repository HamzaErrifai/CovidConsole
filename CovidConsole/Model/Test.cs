using System;
using System.Data;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Test : Model
    {
        public Test()
        {
            tableName = "test";
        }
        protected void addData(string typeT, DateTime dateT, bool hassymptoms, string resultat, string cinC)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            int HasSymptoms = hassymptoms ? 1 : 0;

            try
            {
                conn.Open();
                command.CommandText = $"INSERT INTO test (typeT, dateT, hassymptoms, resultat, cinC)" +
                    $"VALUES ('{typeT}', '{dateT.ToString("MM/dd/yyyy HH:mm:ss")}', {HasSymptoms}, '{resultat}', '{cinC}')";
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
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
            command.CommandText = $"SELECT * FROM test WHERE id = {idItem}";
            command.Prepare();
            command.ExecuteNonQuery();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
