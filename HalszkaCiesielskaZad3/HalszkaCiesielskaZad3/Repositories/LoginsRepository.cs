using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class LoginsRepository : Repository, ILoginsRepository
    {
        public int Login(string login, string password)
        {
            Connection.Open();
            string queryGetEmployeeId = "SELECT Id FROM Logins WHERE Login='" + login + "' AND Password ='" + password + "';";
            SqlCommand commandGetEmployeeId = new SqlCommand(queryGetEmployeeId, Connection);
            int employeeId;
            if (commandGetEmployeeId.ExecuteScalar() == null)
            {
                employeeId = 0; 
            }
            else
            {
                employeeId = (int)commandGetEmployeeId.ExecuteScalar();
            }
            Connection.Close();

            return employeeId; 
        }
    }
}
