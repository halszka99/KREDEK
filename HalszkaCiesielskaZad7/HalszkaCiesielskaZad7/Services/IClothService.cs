using System.Collections.Generic;
using HalszkaCiesielskaZad7.Models;

namespace HalszkaCiesielskaZad7.Services
{
    public interface IClothService
    {
        /// <summary>
        /// Giving list of all clothes
        /// </summary>
        /// <returns></returns>
        List<Cloth> GetAllClothes();
        /// <summary>
        /// Updating selected cloth 
        /// </summary>
        /// <param name="cloth"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool UpdateCloth(Cloth cloth, int id);
        /// <summary>
        /// Ading new cloth
        /// </summary>
        /// <param name="cloth"></param>
        /// <returns></returns>
        int AddCloth(Cloth cloth);
        /// <summary>
        /// Deleting selected cloth
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteCloth(int id);
    }
}
