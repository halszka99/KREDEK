using System.Collections.Generic;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Interface deifining methods related to communication with table Areas from database ZOO 
    /// </summary>
    interface IAreasRepository
    {
        /// <summary>
        /// Abstract method to returning all of the areas 
        /// </summary>
        /// <returns></returns>
        List<AreaViewModel> GetAreas();
    }
}

