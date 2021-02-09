using System.Data;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Interface deifining methods related to communication with table AnimalClasses from database ZOO 
    /// </summary>
    interface IAnimalClassesRepository
    {
        /// <summary>
        /// Abstract method to returning all of the animal classes
        /// </summary>
        /// <returns></returns>
        DataTable GetAnimalClasses();
        /// <summary>
        /// Abstract method to returning set of names of animal classes 
        /// </summary>
        /// <returns></returns>
        DataSet GetAnimalClassesNames();
    }
}
