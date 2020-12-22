using System.Data;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    abstract class Model
    {
        protected static string tableName = "";

        protected static DataTable getData()
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            conn.Open();
            command.CommandText = $"SELECT * FROM {tableName}";
            command.Prepare();
            command.ExecuteNonQuery();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
