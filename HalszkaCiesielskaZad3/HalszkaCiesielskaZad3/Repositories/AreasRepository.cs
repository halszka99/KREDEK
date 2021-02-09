using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table Areas from database ZOO 
    /// </summary>
    class AreasRepository : Repository, IAreasRepository
    {
        /// <summary>
        /// Method returning all of the areas 
        /// </summary>
        /// <returns></returns>
        public DataTable GetAreas()
        {
            // opening connection with database
            Connection.Open();
            // creating query to get all areas data from database
            string querySelectAreas = "SELECT Areas.Name,Count(*) AS 'Amount of cages' FROM Cages JOIN Areas ON Cages.AreaId = Areas.Id GROUP BY Areas.Name;";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAreas, Connection);
            // creating data table
            DataTable table = new DataTable();
            // filling table with data from databes
            adapter.Fill(table);
            // closing connection
            Connection.Close();
            // returning table 
            return table;
        }
    }
}
