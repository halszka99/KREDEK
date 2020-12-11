using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    public abstract class Repository
    {
        protected readonly SqlConnection Connection;

        protected Repository()
        {
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}
