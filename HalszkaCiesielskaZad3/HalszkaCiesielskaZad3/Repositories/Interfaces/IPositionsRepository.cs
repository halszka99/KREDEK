using System.Data;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Intefrace deifining methods related to communication with table Positions from database ZOO 
    /// </summary>
    interface IPositionsRepository
    {
        /// <summary>
        /// Abstract method to returning all of the positions 
        /// </summary>
        /// <returns></returns>
        DataTable GetPositions();
        /// <summary>
        /// Abstract method to returning set of names of positions 
        /// </summary>
        /// <returns></returns>
        DataSet GetPositionsNames(); 
    }
}
