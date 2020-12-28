using System.Data;

namespace CovidConsole.Controller
{
    class Admin : Model.Admin
    {
        DataTable dt;

        public Admin()
        {
            //takes informations about the admin
            //username in the database is unique
            dt = getData();
        }

        public bool verifyConnection(string username, string pwd)
        {
            foreach (DataRow row in dt.Rows)
                if (row["username"].ToString() == username && row["pwd"].ToString() == pwd)
                    return true;
            return false;
        }



    }
}
