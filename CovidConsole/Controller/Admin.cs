namespace CovidConsole.Controller
{
    class Admin : Model.Admin
    {
        string username;
        string pwd;

        public Admin()
        {
            //takes informations about the admin
            var dt = getData();
            username = dt.Rows[0]["username"].ToString();
            pwd = dt.Rows[0]["pwd"].ToString();
        }

        public bool verifyConnection(string username, string pwd)
        {
            return (username == this.username && pwd == this.pwd);
        }
    }
}
