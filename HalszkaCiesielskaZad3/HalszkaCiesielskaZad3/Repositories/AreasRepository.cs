using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class AreasRepository : Repository, IAreasRepository
    {
        public DataTable GetAreas()
        {
            Connection.Open();
            string querySelectAreas = "SELECT Areas.Name,Count(*) AS 'Amount of cages' FROM Cages JOIN Areas ON Cages.AreaId = Areas.Id GROUP BY Areas.Name;";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAreas, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

            return table;
        }
    }
}
