using System.Data;
using System.Data.SqlClient;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Class deifining methods related to communication with table Emoloyees from database ZOO 
    /// </summary>
    class EmployeesRepository : Repository, IEmployeesRepository
    {
        /// <summary>
        /// Method returning all of the employees.
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmployees()
        {
            // opening connection with database
            Connection.Open();
            // creating query to get all employees data from database
            string querySelectEmployees = "SELECT Employees.FirstName as 'First name', Employees.LastName as 'Last name', Positions.Name as 'Profession', Positions.Salary " + 
                "FROM Employees JOIN Positions ON Employees.PositionId = Positions.Id; ";
            // creating sql data adapter from the above query
            SqlDataAdapter adapter = new SqlDataAdapter(querySelectEmployees, Connection);
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
        /// Method to create employee. 
        /// </summary>
        /// <param name="employeeFirstName"></param>
        /// <param name="employeeLastName"></param>
        /// <param name="employeePositions"></param>
        public void CreateEmployee(string employeeFirstName, string employeeLastName, string employeePositions)
        {
            // opening connection with database
            Connection.Open();
            // creating query to get id  of given position
            string queryGetPositionId = "SELECT Id FROM Positions WHERE Name='" + employeePositions + "';";
            //creating sql command from the above query 
            SqlCommand commandGetPositionId = new SqlCommand(queryGetPositionId, Connection);
            // setting positionId to returned value
            int positionId = (int)commandGetPositionId.ExecuteScalar();
            // creating query to add employee to database with given data
            string createEmployeeQuery = "INSERT INTO Employees VALUES ('" + employeeFirstName + "','" + employeeLastName + "'," + positionId + ");";
            //creating sql command from the above query 
            SqlCommand commandCreateEmployee = new SqlCommand(createEmployeeQuery, Connection);
            // executing query
            commandCreateEmployee.ExecuteNonQuery();
            // creating query to get id of inserted employee
            string queryGetEmployeeId = "SELECT Id FROM Employees WHERE FirstName='" + employeeFirstName + "' AND LastName = '" + employeeLastName + "' AND PositionId = " + positionId + ";";
            //creating sql command from the above query 
            SqlCommand commandGetEmployeeId = new SqlCommand(queryGetEmployeeId, Connection);
            //setting employeeId to returned value
            int employeelId = (int)commandGetEmployeeId.ExecuteScalar();
            // creating query to add employee login data to database (default login and password are his first name)
            string createLoginForEmployeeQuery = "INSERT INTO Logins VALUES ('" + employeeFirstName + "','" + employeeFirstName + "'," + employeelId + ");";
            //creating sql command from the above query 
            SqlCommand commandCreateLoginForEmployee = new SqlCommand(createLoginForEmployeeQuery, Connection);
            // executing query
            commandCreateLoginForEmployee.ExecuteNonQuery();
            // closing connection
            Connection.Close();
        }
        /// <summary>
        /// Method to generate contents od the welcome message.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public string WelcomeMessage(int employeeId)
        {
            // opening connection with database
            Connection.Open();
            // creating query to get welcome message with employee first name and last name depending on his id
            string queryGetWelcomeMessage = "SELECT CONCAT('Hello ', FirstName, ' ', LastName, '!') FROM Employees WHERE Id=" + employeeId + ";";
            //creating sql command from the above query 
            SqlCommand commandGetWelcomeMessage = new SqlCommand(queryGetWelcomeMessage, Connection);
            // setting welcomeMessage to returned string
            string welcomeMessage = commandGetWelcomeMessage.ExecuteScalar().ToString();
            // closing connection
            Connection.Close();
            //returning welcomeMessage
            return welcomeMessage;
        }
    }
}
