using System.Data;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Model
    {
        protected string tableName = "";

        protected DataTable getData()
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

        /*idDbName : nom du id dans la base de données
         * idItem  : valeur de l'id
         * @return datatable
         * **/
        protected DataTable getById(string idItem, string idDbName)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            conn.Open();
            command.CommandText = $"SELECT * FROM {tableName} WHERE {idDbName} = {idItem}";
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
        protected void UpdateItem(string idDbName, string idItem, string itemName, string itemValue)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);

            conn.Open();
            command.CommandText = $"UPDATE {tableName} SET {itemName} = '{itemValue}' WHERE {idDbName} = {idItem}" ;
            command.Prepare();
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
