using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Class deifining methods related to communication with table Animals from database ZOO 
    /// </summary>
    class AnimalsRepository : Repository, IAnimalsRepository
    {
        /// <summary>
        /// Method returning all of the animals 
        /// </summary>
        /// <returns></returns>
        public List<AnimalViewModel> GetAnimals()
        {
            //creating list of animals
            List<Animal> animals = DbContext.Animals.ToList();
            //returning created and mapped list
            return Mapper.Map<List<Animal>, List<AnimalViewModel>>(animals);

        }
        /// <summary>
        /// Method to create animal.
        /// </summary>
        /// <param name="animalName"></param>
        /// <param name="animalClass"></param>
        /// <param name="cageNumber"></param>
        public bool CreateAnimal(string animalName, string animalClass, int cageNumber)
        {
            //creating object of AnimalClass that name is equal to animalClass
            AnimalClass animalClassOfAnimal = DbContext.AnimalClasses.SingleOrDefault(c => c.Name == animalClass);
            // checking if animalClassOfAnimal is null and returning false if it is
            if (animalClassOfAnimal == null)
                return false;
            // adding new Animal with given data
            DbContext.Animals.Add(new Animal()
            {
                Name = animalName,
                AnimalClass = animalClassOfAnimal,
                CageId=cageNumber
            });
            // saving changes
            return DbContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Method to update animal data. 
        /// </summary>
        /// <param name="newAnimalName"></param>
        /// <param name="newAnimalClass"></param>
        /// <param name="newCageNumber"></param>
        /// <param name="animalId"></param>
        public bool UpdateAnimal(string newAnimalName, string newAnimalClass, int newCageNumber, int animalId)
        {
            //finding object to update
            Animal animal = DbContext.Animals.SingleOrDefault(a => a.Id == animalId);
            // creating object of AnimalClass that name is equal to animalClass
            AnimalClass animalClassOfAnimal = DbContext.AnimalClasses.SingleOrDefault(c => c.Name == newAnimalClass);
            // checking if animalClassOfAnimal is null and returning false if it is
            if (animalClassOfAnimal == null )
                return false;
            //changing object properties 
            animal.Name = newAnimalName;
            animal.CageId = newCageNumber;
            animal.AnimalClass = animalClassOfAnimal;
            // saving changes
            return DbContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Method to delete animal.
        /// </summary>
        /// <param name="animalId"></param>
        public bool DeleteAnimal(int animalId)
        {
            //removing animal that id is equal to given animalId
            DbContext.Animals.Remove(DbContext.Animals.SingleOrDefault(a => a.Id == animalId));
            // saving changes
            return DbContext.SaveChanges() > 0;
        }
    }
}
