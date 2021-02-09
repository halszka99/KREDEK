using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalszkaCiesielskaZad2
{
    public class FlyingBird : Bird
    {   /// <summary>
        /// FlyingBird parameterless constructor 
        /// </summary>
        public FlyingBird()
        {
        }
        /// <summary>
        /// FlyingBird constructor with name parameter
        /// </summary>
        /// <param name="name"></param>
        public FlyingBird(string name)
        {
            // setting name to given name
            Name = name;
            // setting random weight 
            Weight = random.Next(250, 750);
            // setting moodLevel to 100%
            MoodLevel = 100;
            // setting foodLevel to 100%
            FoodLevel = 100;
        }
        /// <summary>
        /// Calculating FlyingBird speed including bonus for flying
        /// </summary>
        /// <returns></returns>
        public new float Go()
        {
            return -Weight + FoodLevel + 10;
        }

    }
}
