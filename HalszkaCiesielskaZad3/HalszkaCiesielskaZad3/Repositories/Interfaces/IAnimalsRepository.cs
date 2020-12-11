using System.Data;

namespace HalszkaCiesielskaZad3
{
    interface IAnimalsRepository
    {
        DataTable GetAnimals();
        void CreateAnimal(string animalName, string animalClass, int cageNumber);
        void UpdateAnimal(string newAnimalName, string newAnimalClass, int newCageNumber, string oldAnimalName, string oldAnimalClass, int oldCageNumber);
        void DeleteAnimal(string selectedAnimalName, string selectedAnimalClass, int selectedCageNumber);

    }
}
