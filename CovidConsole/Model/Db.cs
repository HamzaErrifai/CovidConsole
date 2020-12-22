using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Db
    {
        const string connectionStr = "Data Source=.;Initial Catalog=CovidDB;Integrated Security=True";
        
        public static SqlConnection Connect()
        {
            //it returns sql server connection
            return new SqlConnection(connectionStr);
        } 

    }
}
