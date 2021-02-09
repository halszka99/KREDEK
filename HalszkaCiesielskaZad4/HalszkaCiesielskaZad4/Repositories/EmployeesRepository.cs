using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
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
        public List<EmployeeViewModel> GetEmployees()
        {
            // creating list of employees
            List<Employee> employees = DbContext.Employees.ToList();
            // returning created and mapped list
            return Mapper.Map<List<Employee>, List<EmployeeViewModel>>(employees);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeFirstName"></param>
        /// <param name="employeeLastName"></param>
        /// <param name="employeePositions"></param>
        public void CreateEmployee(string employeeFirstName, string employeeLastName, string employeePositions)
        {
            //creating object of Position that name is equal to employeePositions
            Position positionOfEmployee = DbContext.Positions.SingleOrDefault(c => c.Name == employeePositions);

            //adding new employee with given data
            Employee newEmployee = new Employee()
            {
                FirstName = employeeFirstName,
                LastName = employeeLastName,
                Position = positionOfEmployee
            };
            DbContext.Employees.Add(newEmployee); 

            //adding employee to Logins
            DbContext.Logins.Add(new Login()
            {
                Nickname = employeeFirstName,
                Password = employeeFirstName,
                EmployeeId = newEmployee.Id
            });

            //saving changes
            DbContext.SaveChanges();
        }
        /// <summary>
        /// Method to generate contents od the welcome message.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public string WelcomeMessage(int employeeId)
        {
            //creating object of Employee that is logged
            Employee loggedEmployee = DbContext.Employees.SingleOrDefault(e => e.Id == employeeId);
            //returning personalized message
            return "Welcome " + loggedEmployee.FirstName + " " + loggedEmployee.LastName + "!";      
        }
    }
}
