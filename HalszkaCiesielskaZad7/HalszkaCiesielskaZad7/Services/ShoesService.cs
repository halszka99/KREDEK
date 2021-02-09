using System.Collections.Generic;
using System.Linq;
using HalszkaCiesielskaZad7.Models;

namespace HalszkaCiesielskaZad7.Services
{
    public class ShoesService : IShoesService
    {
        /// <summary>
        /// Initialization of list of shoes with example data
        /// </summary>
        private static List<Shoes> shoesList = new List<Shoes>()
        {
            new Shoes()
            {
                Id= 0, 
                Size = 38, 
                InsoleLength = 24,
                Type = "Heels"
            },
            new Shoes()
            {
                Id= 1,
                Size = 40,
                InsoleLength = 25,
                Type = "Sandals"
            },
            new Shoes()
            {
                Id= 2,
                Size = 40,
                InsoleLength = 25,
                Type = "Boots"
            },
            new Shoes()
            {
                Id= 3,
                Size = 36,
                InsoleLength = 23,
                Type = "Slippers"
            }
        };
        /// <summary>
        /// Method to adding new shoes
        /// </summary>
        /// <param name="shoes"></param>
        /// <returns></returns>
        public int AddShoes(Shoes shoes)
        {
            //declaration of new shoes id
            int newShoesId;
            //checking if shoesList is empty
            if (shoesList.Count() == 0)
            {
                //if it is setting newShoesId to 0
                newShoesId = 0;
            }
            else
            {
                // if list is not empty setting newShoesId to max id + 1
                newShoesId = shoesList.Max(x => x.Id) + 1; 
            }
            //setting new shoes id 
            shoes.Id = newShoesId;
            // adding new shoes to shoesList
            shoesList.Add(shoes);
            //returning added shoes id
            return shoes.Id;
        }
        /// <summary>
        /// Method to delete selected shoes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteShoes(int id)
        {
            //selecting shoes to delete based on id
            Shoes shoesToDelete = shoesList.Where(x=>x.Id==id).SingleOrDefault();
            //removing selected shoes from list
            return shoesList.Remove(shoesToDelete);
        }
        /// <summary>
        /// Method to return all of shoes
        /// </summary>
        /// <returns></returns>
        public List<Shoes> GetAllShoes()
        {
            //returning shoes list
            return shoesList;
        }
        /// <summary>
        /// Method to update selected shoes
        /// </summary>
        /// <param name="shoes"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateShoes(Shoes shoes, int id)
        {
            // choosing shoes to update
            var shoesToUpdate = shoesList.Where(x => x.Id.Equals(id)).SingleOrDefault();
            //returning false if shoes are null
            if (shoesToUpdate == null)
                return false;
            //setting shoesToUpdated properties to given
            shoesToUpdate.InsoleLength = shoes.InsoleLength;
            shoesToUpdate.Size = shoes.Size;
            shoesToUpdate.Type = shoes.Type;
            //returning true
            return true;
        }
    }
}
