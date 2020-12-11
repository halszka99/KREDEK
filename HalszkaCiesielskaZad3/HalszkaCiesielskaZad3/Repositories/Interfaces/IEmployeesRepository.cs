using System.Data;

namespace HalszkaCiesielskaZad3
{
    interface IEmployeesRepository
    {
        DataTable GetEmployees();
        void CreateEmployee(string employeeFirstName, string employeeLastName, string employeePositions);
        string WelcomeMessage(int employeeId); 
    }
}
