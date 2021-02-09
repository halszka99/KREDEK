using System.Data;

namespace HalszkaCiesielskaZad3
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
        DataTable GetFoods();
        /// <summary>
        /// Abstract method to returning set of names of foods
        /// </summary>
        /// <returns></returns>
        DataSet GetFoodsNames();
        /// <summary>
        /// Abstract method to update amount of food 
        /// </summary>
        /// <param name="foodName"></param>
        void UpdateFoodAmount(string foodName);
    }   
}
