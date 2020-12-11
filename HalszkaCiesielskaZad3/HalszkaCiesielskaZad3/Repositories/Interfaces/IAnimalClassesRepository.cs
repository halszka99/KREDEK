using System.Data;

namespace HalszkaCiesielskaZad3
{
    interface IAnimalClassesRepository
    {
        DataTable GetAnimalClasses();
        DataSet GetAnimalClassesNames();
    }
}
