using System.Collections.Generic;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Interface deifining methods related to communication with table Foods from database ZOO 
    /// </summary>
    interface IFoodsRepository
    {
        /// <summary>
        /// Abstract method to returning all of the foods
        /// </summary>
        /// <returns></returns>
        List<FoodViewModel> GetFoods();
        /// <summary>
        /// Abstract method to update amount of food 
        /// </summary>
        /// <param name="foodName"></param>
        void UpdateFoodAmount(string foodName);
    }   
}
