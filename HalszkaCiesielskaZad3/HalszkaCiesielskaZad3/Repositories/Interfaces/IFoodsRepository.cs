using System.Data;

namespace HalszkaCiesielskaZad3
{
    interface IFoodsRepository
    {
        DataTable GetFoods();
        DataSet GetFoodsNames();
        void UpdateFoodAmount(string foodName);
    }   
}
