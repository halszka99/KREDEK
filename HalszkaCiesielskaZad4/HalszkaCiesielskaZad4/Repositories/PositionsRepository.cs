using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Class deifining methods related to communication with table Positions from database ZOO 
    /// </summary>
    class PositionsRepository : Repository, IPositionsRepository
    {
        /// <summary>
        /// Method returning all of the positions 
        /// </summary>
        /// <returns></returns>
        public List<PositionViewModel> GetPositions()
        {
            // creating list of position
            List<Position> positions = DbContext.Positions.ToList();
            // returning created and mapped list
            return Mapper.Map<List<Position>, List<PositionViewModel>>(positions);
        }
    }
}
