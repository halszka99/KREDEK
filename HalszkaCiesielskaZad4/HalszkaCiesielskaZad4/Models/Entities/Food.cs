using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table Foods with properties (columns) 
    /// </summary>
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int AnimalClassId { get; set; }
        [ForeignKey("AnimalClassId")]
        public virtual AnimalClass AnimalClass { get; set; }
    }
}
