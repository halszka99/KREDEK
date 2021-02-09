using System.ComponentModel.DataAnnotations;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table AnimalClasses with properties (columns) 
    /// </summary>
    public class AnimalClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
    }
}
