using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table Cages from database ZOO 
    /// </summary>
    class CagesRepository : Repository, ICagesRepository
    {
        /// <summary>
        /// Method returning all of the cages 
        /// </summary>
        /// <returns></returns>
        public DataTable GetCages()
        {
            // opening connection with database
            Connection.Open();
            // creating query to get all cages data from database
            string querySelectCages = "SELECT Cages.AmountOfPlaces as 'Amount of places in cage', AnimalClasses.Name as 'Animal class', Areas.Name as 'Area name' FROM Cages JOIN AnimalClasses ON Cages.AnimalClassId=AnimalClasses.Id JOIN Areas ON Cages.AreaId=Areas.Id; ";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectCages, Connection);
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
        ///  Method returning set of available cages 
        /// </summary>
        /// <param name="animalClass"></param>
        /// <returns></returns>
        public DataSet GetCagesNames(string animalClass)
        {
            // opening connection with database
            Connection.Open();
            // creating query to get id of given animal class to filter cages
            string queryGetAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + animalClass + "';";
            // creating sql command from the above query
            SqlCommand commandGetAnimalClassId = new SqlCommand(queryGetAnimalClassId, Connection);
            // setting animalClassId to returned value
            int animalClassId = (int)commandGetAnimalClassId.ExecuteScalar();
            // creating query to get all cages id where animal id is equals given animal class id
            string querySelectCagesNumbers = "SELECT Id FROM Cages WHERE AnimalClassId = " + animalClassId +";";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectCagesNumbers, Connection);
            // creating data set
            DataSet dataSet = new DataSet();
            // filling set with ids from database
            adapter.Fill(dataSet, "Cages");
            // closing connection
            Connection.Close();
            // returning dataSet
            return dataSet;
        }
    }
}
