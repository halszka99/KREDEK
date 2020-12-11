using System.Data;

namespace HalszkaCiesielskaZad3
{
    interface ICagesRepository
    {
        DataTable GetCages();
        DataSet GetCagesNames(string animalClass);
    }
}
