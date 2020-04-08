using System.Configuration;


namespace DataAccess
{
    public static class ConnectionString
    {
        public static string getStringConnection()
        {
            return ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        }
    }
}
