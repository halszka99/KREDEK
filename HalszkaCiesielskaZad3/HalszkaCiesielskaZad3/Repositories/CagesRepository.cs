using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class CagesRepository : Repository, ICagesRepository
    {

        public DataTable GetCages()
        {
            Connection.Open();
            string querySelectCages = "SELECT Cages.AmountOfPlaces as 'Amount of places in cage', AnimalClasses.Name as 'Animal class', Areas.Name as 'Area name' FROM Cages JOIN AnimalClasses ON Cages.AnimalClassId=AnimalClasses.Id JOIN Areas ON Cages.AreaId=Areas.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectCages, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

            return table;
        }

        public DataSet GetCagesNames(string animalClass)
        {
            Connection.Open();

            string queryGetAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + animalClass + "';";
            SqlCommand commandGetAnimalClassId = new SqlCommand(queryGetAnimalClassId, Connection);
            int animalClassId = (int)commandGetAnimalClassId.ExecuteScalar();

            string querySelectCagesNumbers = "SELECT Id FROM Cages WHERE AnimalClassId = " + animalClassId +";";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectCagesNumbers, Connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Cages");
            Connection.Close();

            return dataSet;
        }
    }
}
