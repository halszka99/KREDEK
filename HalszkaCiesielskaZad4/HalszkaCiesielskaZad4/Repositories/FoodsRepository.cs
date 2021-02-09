using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad4.Models.Entities;
using HalszkaCiesielskaZad4.ViewModels;

namespace HalszkaCiesielskaZad4
{
    /// <summary>
    /// Class deifining methods related to communication with table Foods from database ZOO 
    /// </summary>
    class FoodsRepository : Repository, IFoodsRepository
    {
        /// <summary>
        /// Method returning all of the foods 
        /// </summary>
        /// <returns></returns>
        public List<FoodViewModel> GetFoods()
        {
            // creating list of foods
            List<Food> foods = DbContext.Foods.ToList();
            // returning created and mapped list
            return Mapper.Map<List<Food>, List<FoodViewModel>>(foods);
        }
        /// <summary>
        /// Method to update amount of food 
        /// </summary>
        /// <param name="foodName"></param>
        public void UpdateFoodAmount(string foodName)
        {
            // creating object of Food that name is equal to foodName
            Food food = DbContext.Foods.SingleOrDefault(f => f.Name == foodName);
            // updating amount of chosen food
            food.Amount += 10; 
            // saving changes
            DbContext.SaveChanges();
        }
    }
}
