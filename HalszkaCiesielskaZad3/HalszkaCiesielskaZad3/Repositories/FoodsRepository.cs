using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class FoodsRepository : Repository, IFoodsRepository
    {
        public DataTable GetFoods()
        {
            Connection.Open();
            string querySelectFoods = "SELECT Foods.Name as 'Food name', Foods.Amount, Foods.Price, AnimalClasses.Name as 'Animal class name' FROM Foods JOIN AnimalClasses ON Foods.AnimalClassId=AnimalClasses.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectFoods, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Connection.Close();

            return table;
        }

        public DataSet GetFoodsNames()
        {
            Connection.Open();
            string querySelectFoodsNames = "SELECT Id,Name FROM Foods; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectFoodsNames, Connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Foods");
            Connection.Close();

            return dataSet;
        }

        public void UpdateFoodAmount(string foodName)
        {
            Connection.Open();
            string updateFoodAmountQuery = "UPDATE Foods SET Amount = Amount + 10 WHERE Name = '" + foodName+ "'; ";
            SqlCommand commandUpdateFoodAmount = new SqlCommand(updateFoodAmountQuery, Connection);
            commandUpdateFoodAmount.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
