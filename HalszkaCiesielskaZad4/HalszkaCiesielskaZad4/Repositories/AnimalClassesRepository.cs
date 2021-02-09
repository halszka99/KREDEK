using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Class deifining methods related to communication with table AnimalClasses from database ZOO 
    /// </summary>
    class AnimalClassesRepository : Repository, IAnimalClassesRepository
    {
        /// <summary>
        /// Method returning all of the animal classes
        /// </summary>
        /// <returns></returns>
        public List<AnimalClassViewModel> GetAnimalClasses()
        {
            //creating list of animal classes
            List<AnimalClass> animalClasses = DbContext.AnimalClasses.ToList();
            //returning created and mapped list
            return Mapper.Map<List<AnimalClass>, List<AnimalClassViewModel>>(animalClasses);
        }
    }
}
