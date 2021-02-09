using System.Collections.Generic;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
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
        List<CageViewModel> GetCages();
        /// <summary>
        /// Abstract method to returning set of available cages 
        /// </summary>
        /// <param name="animalClass"></param>
        /// <returns></returns>
        List<CageViewModel> GetCages(string animalClass);
    }
}
