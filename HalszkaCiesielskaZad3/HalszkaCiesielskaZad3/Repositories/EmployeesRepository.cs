using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    class EmployeesRepository : Repository, IEmployeesRepository
    {
        public DataTable GetEmployees()
        {
            Connection.Open();

            string querySelectEmployees = "SELECT Employees.FirstName as 'First name', Employees.LastName as 'Last name', Positions.Name as 'Profession', Positions.Salary " + 
                "FROM Employees JOIN Positions ON Employees.PositionId = Positions.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectEmployees, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public void CreateEmployee(string employeeFirstName, string employeeLastName, string employeePositions)
        {
            string queryGetPositionId = "SELECT Id FROM Positions WHERE Name='" + employeePositions + "';";

            Connection.Open();

            SqlCommand commandGetPositionId = new SqlCommand(queryGetPositionId, Connection);
            int positionId = (int)commandGetPositionId.ExecuteScalar();

            string createEmployeeQuery = "INSERT INTO Employees VALUES ('" + employeeFirstName + "','" + employeeLastName + "'," + positionId + ");";
            SqlCommand commandCreateEmployee = new SqlCommand(createEmployeeQuery, Connection);
            commandCreateEmployee.ExecuteNonQuery();

            string queryGetEmployeeId = "SELECT Id FROM Employees WHERE FirstName='" + employeeFirstName + "' AND LastName = '" + employeeLastName + "' AND PositionId = " + positionId + ";";
            SqlCommand commandGetEmployeeId = new SqlCommand(queryGetEmployeeId, Connection);
            int employeelId = (int)commandGetEmployeeId.ExecuteScalar();

            string createLoginForEmployeeQuery = "INSERT INTO Logins VALUES ('" + employeeFirstName + "','" + employeeFirstName + "'," + employeelId + ");";
            SqlCommand commandCreateLoginForEmployee = new SqlCommand(createLoginForEmployeeQuery, Connection);
            commandCreateLoginForEmployee.ExecuteNonQuery();

            Connection.Close();
        }

        public string WelcomeMessage(int employeeId)
        {
            Connection.Open();

            string queryGetWelcomeMessage = "SELECT CONCAT('Hello ', FirstName, ' ', LastName, '!') FROM Employees WHERE Id=" + employeeId + ";";
            SqlCommand commandGetWelcomeMessage = new SqlCommand(queryGetWelcomeMessage, Connection);
            string welcomeMessage = commandGetWelcomeMessage.ExecuteScalar().ToString();
            Connection.Close();

            return welcomeMessage;
        }
    }
}
