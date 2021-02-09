using System;

namespace HalszkaCiesielskaZad4.ViewModels
{
    /// <summary>
    /// Class to define view of Cages
    /// </summary>
    public class CageViewModel
    {
        public int Id { get; set; }
        public int AmountOfPlaces { get; set; }
        public String Area { get; set; }
        public String AnimalClass { get; set; }
    }
}
