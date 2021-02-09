using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Class deifining methods related to communication with table Areas from database ZOO 
    /// </summary>
    class AreasRepository : Repository, IAreasRepository
    {
        /// <summary>
        /// Method returning all of the areas 
        /// </summary>
        /// <returns></returns>
        public List<AreaViewModel> GetAreas()
        {
            //creating list of areas
            List<Area> areas = DbContext.Areas.ToList();
            // returning created and mapped list
            return Mapper.Map<List<Area>, List<AreaViewModel>>(areas);
        }
    }
}
