using System.Data;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Inteface deifining methods related to communication with table Cages from database ZOO 
    /// </summary>
    interface ICagesRepository
    {
        /// <summary>
        /// Abstract method to returning all of the cages.
        /// </summary>
        /// <returns></returns>
        DataTable GetCages();
        /// <summary>
        /// Abstract method to returning set of available cages 
        /// </summary>
        /// <param name="animalClass"></param>
        /// <returns></returns>
        DataSet GetCagesNames(string animalClass);
    }
}
