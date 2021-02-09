namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Interface deifining methods related to communication with table Logins from database ZOO 
    /// </summary>
    interface ILoginsRepository
    {
        /// <summary>
        /// Abstract method to implementing login.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        int Login(string login, string password);
    }
}
