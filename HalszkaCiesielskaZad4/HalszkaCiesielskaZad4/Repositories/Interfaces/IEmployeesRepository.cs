using System.Collections.Generic;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{    /// <summary>
     /// Interface deifining methods related to communication with table Emoloyees from database ZOO 
     /// </summary>
    interface IEmployeesRepository
    {
        /// <summary>
        /// Abstract method to returning all of the employees.
        /// </summary>
        /// <returns></returns>
        List<EmployeeViewModel> GetEmployees();
        /// <summary>
        /// Abstract method to create employee
        /// </summary>
        /// <param name="employeeFirstName"></param>
        /// <param name="employeeLastName"></param>
        /// <param name="employeePositions"></param>
        void CreateEmployee(string employeeFirstName, string employeeLastName, string employeePositions);
        /// <summary>
        /// Abstract method to generate contents od the welcome message.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        string WelcomeMessage(int employeeId);
    }
}
