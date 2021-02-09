using System.Data;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Interface deifining methods related to communication with table Animals from database ZOO 
    /// </summary>
    interface IAnimalsRepository
    {
        /// <summary>
        ///  Abstract method to returning all of the animals 
        /// </summary>
        /// <returns></returns>
        DataTable GetAnimals();
        /// <summary>
        /// Abstract method to create animal.
        /// </summary>
        /// <param name="animalName"></param>
        /// <param name="animalClass"></param>
        /// <param name="cageNumber"></param>
        void CreateAnimal(string animalName, string animalClass, int cageNumber);
        /// <summary>
        /// Abstract method to update animal data.
        /// </summary>
        /// <param name="newAnimalName"></param>
        /// <param name="newAnimalClass"></param>
        /// <param name="newCageNumber"></param>
        /// <param name="animalId"></param>
        void UpdateAnimal(string newAnimalName, string newAnimalClass, int newCageNumber, int animalId);
        /// <summary>
        /// Abstract method to delete animal.
        /// </summary>
        /// <param name="animalId"></param>
        void DeleteAnimal(int animalId);

    }
}
