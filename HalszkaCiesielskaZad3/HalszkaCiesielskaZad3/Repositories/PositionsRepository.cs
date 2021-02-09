using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table Positions from database ZOO 
    /// </summary>
    class PositionsRepository : Repository, IPositionsRepository
    {
        /// <summary>
        /// Method returning all of the positions 
        /// </summary>
        /// <returns></returns>
        public DataTable GetPositions()
        {
            // opening connection with database
            Connection.Open();
            // creating query to get all positions data from database
            string querySelectPositions = "SELECT Name as 'Profession name', Salary FROM Positions; ";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectPositions, Connection);
            // creating data table
            DataTable table = new DataTable();
            // filling table with data from databes
            adapter.Fill(table);
            // closing connection
            Connection.Close();
            // returning table 
            return table;
        }
        /// <summary>
        /// Method returning set of names of positions 
        /// </summary>
        /// <returns></returns>
        public DataSet GetPositionsNames()
        {
            // opening connection with database
            Connection.Open();
            //creating query to get all positions names from database
            string querySelectPositionsNames = "SELECT Name FROM Positions; ";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectPositionsNames, Connection);
            // creating data set
            DataSet dataSet = new DataSet();
            // filling set with names from database
            adapter.Fill(dataSet, "Positions");
            // closing connection
            Connection.Close();
            // returning dataSet
            return dataSet; 
        }
    }
}
