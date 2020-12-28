using System.Data;

namespace CovidConsole.Controller
{
    class Admin : Model.Admin
    {
        public string username { get; set; }
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
                if (row["username"].ToString() == username && row["pwd"].ToString() == Utils.hashPwd(pwd))
                {
                    this.username = row["username"].ToString();
                    return true;
                }
            return false;
        }

        public void addAdmin(string username, string pwd)
        {
            addData(username, Utils.hashPwd(pwd));
        }



    }
}
