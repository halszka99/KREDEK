using System;

namespace HalszkaCiesielskaZad4.ViewModels
{
    /// <summary>
    /// Class to define view of Foods
    /// </summary>
    public class FoodViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public String AnimalClass { get; set; }
    }
}
