using System.Data;

namespace HalszkaCiesielskaZad3
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
        DataTable GetAreas();
    }
}

