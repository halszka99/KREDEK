using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalszkaCiesielskaZad2
{
    public class Bird : Animal, IFeed, IGo
    {   /// <summary>
        /// Bird parameterless constructor 
        /// </summary>
        public Bird() 
        {
        }
        /// <summary>
        /// Bird constructor with name parameter
        /// </summary>
        /// <param name="name"></param>
        public Bird(string name)
        {
            // setting name to given name
            Name = name;
            // setting random weight 
            Weight = random.Next(500, 1500);
            // setting moodLevel to 100%
            MoodLevel = 100;
            // setting foodLevel to 100%
            FoodLevel = 100;
        }
        /// <summary>
        /// Feeding bird
        /// </summary>
        /// <returns></returns>
        public int Feed()
        {
            // calculating amount of food for cat depending on its weight
            float amountOfFood = (Weight/500);
            // setting foodLevel to 100%
            FoodLevel = 100;
            // returning calculated amount of food
            return (int)amountOfFood;
        }
        /// <summary>
        /// Calculating bird speed 
        /// </summary>
        /// <returns></returns>
        public float Go()
        {
            return -Weight/2 + FoodLevel;
        }
    }
}
