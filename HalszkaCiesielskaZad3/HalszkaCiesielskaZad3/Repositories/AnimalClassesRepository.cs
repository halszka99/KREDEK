using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table AnimalClasses from database ZOO 
    /// </summary>
    class AnimalClassesRepository : Repository, IAnimalClassesRepository
    {
        /// <summary>
        /// Method returning all of the animal classes 
        /// </summary>
        /// <returns></returns>
        public DataTable GetAnimalClasses()
        {
            // opening connection with database
            Connection.Open();
            // creating query to get all animal classes data from database
            string querySelectAnimalClasses = "SELECT Name as 'Animal class name' FROM AnimalClasses;";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAnimalClasses, Connection);
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
        ///  Method returning set of names of animal classes 
        /// </summary>
        /// <returns></returns>
        public DataSet GetAnimalClassesNames()
        {
            // opening connection with database
            Connection.Open();
            //creating query to get all animal classes names from database
            string querySelectAnimalClassesNames = "SELECT Name FROM AnimalClasses; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectAnimalClassesNames, Connection);
            // creating sql data adapter from the above query
            DataSet dataSet = new DataSet();
            // filling set with names from database
            adapter.Fill(dataSet, "Animal Classes");
            // closing connection
            Connection.Close();
            // returning dataSet
            return dataSet;
        }
    }
}
