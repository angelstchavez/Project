using System.Configuration;

namespace Project.Data.Connection
{
    public class MasterConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
    }
}
