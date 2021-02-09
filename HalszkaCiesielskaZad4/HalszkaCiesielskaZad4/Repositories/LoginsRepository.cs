using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;

namespace HalszkaCiesielskaZad4
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
        public int Login(string nickname, string password)
        {
            // creating object of Login that Nickname is equal to nickname and Password is equal to password
            Login logged = DbContext.Logins.FirstOrDefault(l => l.Nickname == nickname && l.Password == password);
            // checking if there is user with given data
            if (logged != null)
            {
                //returning id of logged user
                return logged.EmployeeId;
            }
            else 
            {
                //returning 0 if none is logged
                return 0; 
            }
        }
    }
}
