using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table Animals from database ZOO 
    /// </summary>
    class AnimalsRepository : Repository, IAnimalsRepository
    {
        /// <summary>
        /// Method returning all of the animals 
        /// </summary>
        /// <returns></returns>
        public DataTable GetAnimals()
        {
            // opening connection with database
            Connection.Open();
            // creating query to get all animals data from database
            string querySelectAnimal = "SELECT Animals.Name as 'Animal name', Areas.Name as 'Area name', Animals.CageId as 'Cage number', AnimalClasses.Name as 'Animal class name', Animals.Id "+
                "FROM Animals JOIN AnimalClasses ON AnimalClasses.Id = Animals.AnimalClassId JOIN Cages ON Cages.Id=Animals.CageId JOIN Areas ON Areas.Id = Cages.AreaId; ";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAnimal, Connection);
            // creating data table
            DataTable table = new DataTable();
            // filling table with data from database
            adapter.Fill(table);
            // closing connection
            Connection.Close();
            // returning table 
            return table;
        }
        /// <summary>
        /// Method to create animal.
        /// </summary>
        /// <param name="animalName"></param>
        /// <param name="animalClass"></param>
        /// <param name="cageNumber"></param>
        public void CreateAnimal(string animalName, string animalClass, int cageNumber)
        {
            // opening connection with database
            Connection.Open();
            // creating query to get id of given animal class 
            string queryGetAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + animalClass + "';";
            //creating sql command from the above query 
            SqlCommand commandGetAnimalClassId = new SqlCommand(queryGetAnimalClassId, Connection);
            // setting animalClassId to returned value
            int animalClassId = (int)commandGetAnimalClassId.ExecuteScalar();
            //creating query to add new animal to database
            string createAnimalQuery = "INSERT INTO Animals VALUES ('" + animalName + "'," + cageNumber + "," + animalClassId + ");";
            //creating sql command from the above query
            SqlCommand commandCreateAnimal = new SqlCommand(createAnimalQuery, Connection);
            //executing query
            commandCreateAnimal.ExecuteNonQuery();
            // closing connection
            Connection.Close();
        }
        /// <summary>
        /// Method to update animal data. 
        /// </summary>
        /// <param name="newAnimalName"></param>
        /// <param name="newAnimalClass"></param>
        /// <param name="newCageNumber"></param>
        /// <param name="animalId"></param>
        public void UpdateAnimal(string newAnimalName, string newAnimalClass, int newCageNumber, int animalId)
        {
            // opening connection with database
            Connection.Open();
            // creating query to get id of given animal class
            string queryGetAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + newAnimalClass + "';";
            //creating sql command from the above query 
            SqlCommand commandGetAnimalClassId = new SqlCommand(queryGetAnimalClassId, Connection);
            // setting animalClassId to returned value
            int animalClassId = (int)commandGetAnimalClassId.ExecuteScalar();
            // creating query to update animal data
            string updateAnimalQuery = " UPDATE Animals SET Name = '" + newAnimalName + "', AnimalClassId = " + animalClassId + ", CageId = " + newCageNumber + " WHERE Id= + " + animalId + ";";
            //creating sql command from the above query
            SqlCommand commandUpdateAnimal = new SqlCommand(updateAnimalQuery, Connection);
            //executing query
            commandUpdateAnimal.ExecuteNonQuery();
            // closing connection
            Connection.Close();
        }
        /// <summary>
        /// Method to delete animal.
        /// </summary>
        /// <param name="animalId"></param>
        public void DeleteAnimal(int animalId)
        {
            // opening connection with database
            Connection.Open();
            // creating query to delete animal
            string deleteAnimalQuery = " DELETE FROM Animals WHERE Id = " + animalId + ";";
            //creating sql command from the above query 
            SqlCommand commandDeleteAnimal = new SqlCommand(deleteAnimalQuery, Connection);
            // executing query
            commandDeleteAnimal.ExecuteNonQuery();
            // closing connection
            Connection.Close();

        }
    }
}
