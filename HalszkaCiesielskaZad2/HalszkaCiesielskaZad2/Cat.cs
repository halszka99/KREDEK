using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalszkaCiesielskaZad2
{
    class Cat : Animal, IFeed, IGo
    {   /// <summary>
        /// Cat parameterless constructor 
        /// </summary>
        public Cat()
        {
        }
        /// <summary>
        /// Cat constructor with name parameter
        /// </summary>
        /// <param name="name"></param>
        public Cat(string name)
        {
            // setting name to given name
            Name = name;
            // setting random weight 
            Weight = random.Next(1000, 3000);
            // setting moodLevel to 100%
            MoodLevel = 100;
            // setting foodLevel to 100%
            FoodLevel = 100;
        }
        /// <summary>
        /// Feeding cat
        /// </summary>
        /// <returns></returns>
        public int Feed()
        {
            // calculating amount of food for cat depending on its weight
            float amountOfFood = (Weight / 1000);
            // setting foodLevel to 100%
            FoodLevel = 100;
            // returning calculated amount of food
            return (int)amountOfFood;
        }
        /// <summary>
        /// Cat meow - increases its mood and dogs mood reduction
        /// </summary>
        /// <param name="dogs"></param>
        public void Meow(List<Dog> dogs)
        { 
            // increasing cat mood
            MoodLevel += 5;
            // limiting mood level to 100
            if (MoodLevel > 100) MoodLevel = 100;
            // reducing every dog mood level
            for (int i = 0; i < dogs.Count; i++)
            {
                dogs[i].MoodLevel-=5;
                // setting mood level to 0 if it is less than 0 
                if (dogs[i].MoodLevel < 0) MoodLevel = 0; 
            }
        }
        /// <summary>
        /// Calculating cat speed 
        /// </summary>
        /// <returns></returns>
        public float Go()
        {
            return -Weight/4 +FoodLevel; 
        }
    }
}
