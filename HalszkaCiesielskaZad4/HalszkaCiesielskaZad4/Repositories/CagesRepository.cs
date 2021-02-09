using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Class deifining methods related to communication with table Cages from database ZOO 
    /// </summary>
    class CagesRepository : Repository, ICagesRepository
    {
        /// <summary>
        /// Method returning all of the cages 
        /// </summary>
        /// <returns></returns>
        public List<CageViewModel> GetCages()
        {
            // creating list of cages
            List<Cage> cages = DbContext.Cages.ToList();
            // returning created and mapped list
            return Mapper.Map<List<Cage>, List<CageViewModel>>(cages);
        }
        /// <summary>
        /// Method returning set of available cages 
        /// </summary>
        /// <param name="animalClass"></param>
        /// <returns></returns>
        public List<CageViewModel> GetCages(string animalClass)
        {
            // creating object of AnimalClass that name is equal to given animal class name
            AnimalClass animalClassOfAnimal = DbContext.AnimalClasses.SingleOrDefault(c => c.Name == animalClass);
            // creating list of cages available for chosen animal class
            List<Cage> cages = DbContext.Cages.Where(c => c.AnimalClassId == animalClassOfAnimal.Id).ToList();
            // returning created and mapped list
            return Mapper.Map<List<Cage>, List<CageViewModel>>(cages);
        }
    }
}
