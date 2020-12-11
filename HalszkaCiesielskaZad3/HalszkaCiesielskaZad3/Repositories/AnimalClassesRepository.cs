using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class AnimalClassesRepository : Repository, IAnimalClassesRepository
    {
        public DataTable GetAnimalClasses()
        {
            Connection.Open();
            string querySelectAnimalClasses = "SELECT Name as 'Animal class name' FROM AnimalClasses;";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAnimalClasses, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

            return table;
        }

        public DataSet GetAnimalClassesNames()
        {
            Connection.Open();
            string querySelectAnimalClassesNames = "SELECT Id,Name FROM AnimalClasses; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAnimalClassesNames, Connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Animal Classes");
            Connection.Close();

            return dataSet;
        }
    }
}
