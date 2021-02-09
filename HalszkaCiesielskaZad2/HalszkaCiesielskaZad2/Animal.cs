using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalszkaCiesielskaZad2
{
    public abstract class Animal
    {
        public Random random = new Random();
        /// <summary>
        /// Variable to storage animal name
        /// </summary>
        private String name;
        /// <summary>
        /// Variable to storage animal weight
        /// </summary>
        private int weight;
        /// <summary>
        /// Variable to storage level of animal mood (in percents)
        /// </summary>
        private int moodLevel;
        /// <summary>
        /// Variable to define how full animal is (in percents)
        /// </summary>
        private int foodLevel;

        /// <summary>
        /// Playing with animal, improving animal mood
        /// </summary>
        public void Play()
        {
            // increasing animal mood level 
            moodLevel+=10;
            // limiting the mood level to 100 because it is in percents
            if (moodLevel > 100) moodLevel = 100; 
        }
        /// <summary>
        /// Properties referencing to attributes with get and set methods
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public int MoodLevel { get { return moodLevel; } set { moodLevel = value; } }
        public int FoodLevel { get { return foodLevel; } set { foodLevel = value; } }


    }
}
