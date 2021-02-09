using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Abstract class with methods all repositories should have
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Variable to storage connection with database.
        /// </summary>
        protected readonly SqlConnection Connection;
        /// <summary>
        /// Method to initialize connection with database. 
        /// </summary>
        protected Repository()
        {
            // initialization of connection with database 
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}
