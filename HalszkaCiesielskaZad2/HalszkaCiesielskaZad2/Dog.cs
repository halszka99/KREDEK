using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalszkaCiesielskaZad2
{
    class Dog : Animal, IFeed, IGo
    {
        /// <summary>
        /// Dog parameterless constructor 
        /// </summary>
        public Dog()
        {
        }
        /// <summary>
        /// Dog constructor with name parameter
        /// </summary>
        /// <param name="name"></param>
        public Dog(string name)
        {
            // setting name to given name
            Name = name;
            // setting random weight 
            Weight = random.Next(10000,30000);
            // setting moodLevel to 100%
            MoodLevel = 100;
            // setting foodLevel to 100%
            FoodLevel = 100; 
        }
        /// <summary>
        /// Feeding dog
        /// </summary>
        /// <returns></returns>
        public int Feed()
        {
            // calculating amount of food for dog depending on its weight
            float amountOfFood = (Weight / 10000);
            // setting foodLevel to 100%
            FoodLevel = 100;
            // returning calculated amount of food
            return (int)amountOfFood;
        }
        /// <summary>
        /// Calculating dog speed 
        /// </summary>
        /// <returns></returns>
        public float Go()
        {
            return -Weight / 40 + FoodLevel;
        }
        /// <summary>
        /// Dog barking - increases its mood and cats mood reduction
        /// </summary>
        /// <param name="cats"></param>
        public void Woof(List<Cat> cats)
        {
            // increasing dog mood
            MoodLevel += 5;
            // limiting mood level to 100
            if (MoodLevel > 100) MoodLevel = 100;

            // reducing every cat mood level
            for (int i = 0; i < cats.Count; i++)
            {
                cats[i].MoodLevel -= 5;
                // setting mood level to 0 if it is less than 0 
                if (cats[i].MoodLevel < 0) MoodLevel = 0;
            }
        }
    }
}
