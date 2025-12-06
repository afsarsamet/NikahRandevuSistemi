using System.Data.SqlClient;
using System.Configuration;

public static class Db
{
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(
            ConfigurationManager.ConnectionStrings["connStr"].ConnectionString
        );
    }
}
