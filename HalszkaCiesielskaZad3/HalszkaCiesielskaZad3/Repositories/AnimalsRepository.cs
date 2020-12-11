using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class AnimalsRepository : Repository, IAnimalsRepository
    {
        public DataTable GetAnimals()
        {
            Connection.Open();
            string querySelectAnimal = "SELECT Animals.Name as 'Animal name', Areas.Name as 'Area name', Animals.CageId as 'Cage number', AnimalClasses.Name as 'Animal class name' "+
                "FROM Animals JOIN AnimalClasses ON AnimalClasses.Id = Animals.AnimalClassId JOIN Cages ON Cages.Id=Animals.CageId JOIN Areas ON Areas.Id = Cages.AreaId; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAnimal, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

            return table;
        }

        public void CreateAnimal(string animalName, string animalClass, int cageNumber)
        {
            string queryGetAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + animalClass + "';";

            Connection.Open();

            SqlCommand commandGetAnimalClassId = new SqlCommand(queryGetAnimalClassId, Connection);
            int animalClassId = (int)commandGetAnimalClassId.ExecuteScalar();

            string createAnimalQuery = "INSERT INTO Animals VALUES ('" + animalName + "'," + cageNumber + "," + animalClassId + ");";
            SqlCommand commandCreateAnimal = new SqlCommand(createAnimalQuery, Connection);
            commandCreateAnimal.ExecuteNonQuery();

            Connection.Close();
        }

        public void UpdateAnimal(string newAnimalName, string newAnimalClass, int newCageNumber, string oldAnimalName, string oldAnimalClass, int oldCageNumber)
        {
            Connection.Open();

            string queryGetOldAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + oldAnimalClass + "';";
            SqlCommand commandGetOldAnimalClassId = new SqlCommand(queryGetOldAnimalClassId, Connection);
            int oldAnimalClassId = (int)commandGetOldAnimalClassId.ExecuteScalar();

            string queryGetAnimalId = "SELECT Id FROM Animals WHERE Name='" + oldAnimalName + "' AND AnimalClassId = " + oldAnimalClassId + " AND CageId = " + oldCageNumber + ";";
            SqlCommand commandGetAnimalId = new SqlCommand(queryGetAnimalId, Connection);
            int animalId= (int)commandGetAnimalId.ExecuteScalar();

            string queryGetAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + newAnimalClass + "';";
            SqlCommand commandGetAnimalClassId = new SqlCommand(queryGetAnimalClassId, Connection);
            int animalClassId = (int)commandGetAnimalClassId.ExecuteScalar();

            string updateAnimalQuery = " UPDATE Animals SET Name = '" +newAnimalName +"', AnimalClassId = " + animalClassId +", CageId = "+newCageNumber +" WHERE Id= + " + animalId + ";";
            SqlCommand commandUpdateAnimal = new SqlCommand(updateAnimalQuery, Connection);
            commandUpdateAnimal.ExecuteNonQuery();

            Connection.Close();
        }

        public void DeleteAnimal(string selectedAnimalName, string selectedAnimalClass, int selectedCageNumber)
        {
            Connection.Open();

            string queryGetAnimalClassId = "SELECT Id FROM AnimalClasses WHERE Name='" + selectedAnimalClass + "';";
            SqlCommand commandGetAnimalClassId = new SqlCommand(queryGetAnimalClassId, Connection);
            int animalClassId = (int)commandGetAnimalClassId.ExecuteScalar();

            string queryGetAnimalId = "SELECT Id FROM Animals WHERE Name='" + selectedAnimalName + "' AND AnimalClassId = " + animalClassId + " AND CageId = " + selectedCageNumber + ";";
            SqlCommand commandGetAnimalId = new SqlCommand(queryGetAnimalId, Connection);
            int animalId = (int)commandGetAnimalId.ExecuteScalar();

            string deleteAnimalQuery = " DELETE FROM Animals WHERE Id = " + animalId + ";";
            SqlCommand commandDeleteAnimal = new SqlCommand(deleteAnimalQuery, Connection);
            commandDeleteAnimal.ExecuteNonQuery();

            Connection.Close();

        }
    }
}
