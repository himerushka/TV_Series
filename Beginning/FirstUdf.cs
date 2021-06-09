
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
namespace Beginning
{
    public class T
    {
        [SqlFunction(DataAccess = DataAccessKind.Read)]
        public static int ReturnOrderCount()
        {
            using (SqlConnection conn
                = new SqlConnection("context connection=true"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) AS 'Order Count' FROM SalesOrderHeader", conn);
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}

