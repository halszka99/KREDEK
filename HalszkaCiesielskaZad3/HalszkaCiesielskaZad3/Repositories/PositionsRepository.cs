using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class PositionsRepository : Repository, IPositionsRepository
    {
        public DataTable GetPositions()
        {
            Connection.Open();
            string querySelectPositions = "SELECT Name as 'Profession name', Salary FROM Positions; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectPositions, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();
            return table;
        }

        public DataSet GetPositionsNames()
        {
            Connection.Open();
            string querySelectPositionsNames = "SELECT Id,Name FROM Positions; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectPositionsNames, Connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Positions");
            Connection.Close();

            return dataSet; 
        }
    }
}
