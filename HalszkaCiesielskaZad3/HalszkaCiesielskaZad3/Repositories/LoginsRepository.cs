using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table Logins from database ZOO 
    /// </summary>
    class LoginsRepository : Repository, ILoginsRepository
    {
        /// <summary>
        /// Method implementing login.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int Login(string login, string password)
        {
            // opening connection with database
            Connection.Open();
            // creating query to get id of employee with given login and password
            string queryGetEmployeeId = "SELECT Id FROM Logins WHERE Login='" + login + "' AND Password ='" + password + "';";
            // creating sql command from the above query 
            SqlCommand commandGetEmployeeId = new SqlCommand(queryGetEmployeeId, Connection);
            // declaration of variable to storage logged employee id
            int employeeId;
            // checking if the result of the query is null 
            if (commandGetEmployeeId.ExecuteScalar() == null)
            {
                // if it is null setting employeeId to 0
                employeeId = 0; 
            }
            else
            {
                // if it is not null setting the employeeId to returned value 
                employeeId = (int)commandGetEmployeeId.ExecuteScalar();
            }
            // closing connection
            Connection.Close();
            // returning logged employeeId
            return employeeId; 
        }
    }
}
