using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table Animals with properties (columns) 
    /// </summary>
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public int CageId { get; set; }
        [ForeignKey("CageId")]
        public virtual Cage Cage { get; set; }

        [Required]
        public int AnimalClassId { get; set; }
        [ForeignKey("AnimalClassId")]
        public virtual AnimalClass AnimalClass { get; set; }
    }
}
