using System.Collections.Generic;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
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
        List<PositionViewModel> GetPositions();
    }
}
