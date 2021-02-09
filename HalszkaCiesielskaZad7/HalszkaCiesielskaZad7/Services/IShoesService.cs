using System.Collections.Generic;
using HalszkaCiesielskaZad7.Models;

namespace HalszkaCiesielskaZad7.Services
{
    public interface IShoesService
    {
        /// <summary>
        /// Giving list of all shoes
        /// </summary>
        /// <returns></returns>
        List<Shoes> GetAllShoes();
        /// <summary>
        /// Updating selected shoes 
        /// </summary>
        /// <param name="shoes"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool UpdateShoes(Shoes shoes, int id);
        /// <summary>
        /// Ading new shoes
        /// </summary>
        /// <param name="shoes"></param>
        /// <returns></returns>
        int AddShoes(Shoes shoes);
        /// <summary>
        /// Deleting selected shoes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteShoes(int id);
    }
}
