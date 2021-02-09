using System;
using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad7.Models;

namespace HalszkaCiesielskaZad7.Services
{
    public class ClothService : IClothService
    {
        /// <summary>
        /// Initialization of list of clothes with example data
        /// </summary>
        private static List<Cloth> clothesList = new List<Cloth>()
        {
            new Cloth()
            {
                Id= 0,
                Size = 38,
                Fabric = "Linen",
                Category = "Dress"
            },
            new Cloth()
            {
                Id= 1,
                Size = 40,
                Fabric = "Wool",
                Category = "Sweater"
            },
            new Cloth()
            {
                Id= 2,
                Size = 40,
                Fabric = "Polyester",
                Category = "Shirt"
            },
            new Cloth()
            {
                Id= 3,
                Size = 36,
                Fabric = "Cotton",
                Category = "T-shirt"
            }
        };
        /// <summary>
        /// Method to adding new cloth
        /// </summary>
        /// <param name="cloth"></param>
        /// <returns></returns>
        public int AddCloth(Cloth cloth)
        {
            //declaration of new cloth id
            int newClothId;
            //checking if clothesList is empty
            if (clothesList.Count() == 0)
            {
                //if it is setting newClothId to 0
                newClothId = 0;
            }
            else
            {
                // if list is not empty setting newClothId to max id + 1
                newClothId = clothesList.Max(x => x.Id) + 1;
            }
            //setting new cloth id 
            cloth.Id = newClothId;
            // adding new cloth to clothesList
            clothesList.Add(cloth);
            //returning added cloth id
            return cloth.Id;
        }
        /// <summary>
        /// Method to delete selected cloth
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteCloth(int id)
        {
            //selecting cloth to delete based on id
            Cloth clothToDelete = clothesList.Where(x => x.Id == id).SingleOrDefault();
            //removing selected cloth from list
            return clothesList.Remove(clothToDelete);
        }
        /// <summary>
        /// Method to return all of clothes
        /// </summary>
        /// <returns></returns>
        public List<Cloth> GetAllClothes()
        {
            //returning clothes list
            return clothesList;
        }
        /// <summary>
        /// Method to update selected cloth
        /// </summary>
        /// <param name="cloth"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateCloth(Cloth cloth, int id)
        {
            // choosing cloth to update
            var clothToUpdate = clothesList.Where(x => x.Id.Equals(id)).SingleOrDefault();
            //returning false if cloth is null
            if (clothToUpdate == null)
                return false;
            //setting clothToUpdate properties to given
            clothToUpdate.Category = cloth.Category;
            clothToUpdate.Size = cloth.Size;
            clothToUpdate.Fabric = cloth.Fabric;
            //returning true
            return true;
        }
    }
}
