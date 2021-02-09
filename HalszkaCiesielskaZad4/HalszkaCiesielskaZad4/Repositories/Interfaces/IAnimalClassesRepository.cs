using System.Collections.Generic;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
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
        List<AnimalClassViewModel> GetAnimalClasses();

    }
}
