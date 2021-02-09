using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table Foods from database ZOO 
    /// </summary>
    class FoodsRepository : Repository, IFoodsRepository
    {
        /// <summary>
        /// Method returning all of the foods 
        /// </summary>
        /// <returns></returns>
        public DataTable GetFoods()
        {
            // opening connection with database
            Connection.Open();
            // creating query to get all foods data from database
            string querySelectFoods = "SELECT Foods.Name as 'Food name', Foods.Amount, Foods.Price, AnimalClasses.Name as 'Animal class name' FROM Foods JOIN AnimalClasses ON Foods.AnimalClassId=AnimalClasses.Id; ";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectFoods, Connection);
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
        ///  Method returning set of names of foods
        /// </summary>
        /// <returns></returns>
        public DataSet GetFoodsNames()
        {
            // opening connection with database
            Connection.Open();
            //creating query to get all foods names from database
            string querySelectFoodsNames = "SELECT Name FROM Foods; ";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectFoodsNames, Connection);
            // creating data set
            DataSet dataSet = new DataSet();
            // filling set with names from database
            adapter.Fill(dataSet, "Foods");
            // closing connection
            Connection.Close();
            // returning dataSet
            return dataSet;
        }
        /// <summary>
        /// Method to update amount of food 
        /// </summary>
        /// <param name="foodName"></param>
        public void UpdateFoodAmount(string foodName)
        {
            // opening connection with database
            Connection.Open();
            // creating query to update food amount in database
            string updateFoodAmountQuery = "UPDATE Foods SET Amount = Amount + 10 WHERE Name = '" + foodName+ "'; ";
            //creating sql command from the above query 
            SqlCommand commandUpdateFoodAmount = new SqlCommand(updateFoodAmountQuery, Connection);
            // executing query
            commandUpdateFoodAmount.ExecuteNonQuery();
            // closing connection
            Connection.Close();
        }
    }
}
