using System;

namespace HalszkaCiesielskaZad4.ViewModels
{
    /// <summary>
    /// Class to define view of Animals
    /// </summary>
    public class AnimalViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CageId { get; set; }
        public String AnimalClass { get; set; }
    }
}
