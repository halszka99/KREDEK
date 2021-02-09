using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table Cages with properties (columns) 
    /// </summary>
    public class Cage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AmountOfPlaces { get; set; }

        [Required]
        public int AreaId { get; set; }
        [ForeignKey("AreaId")]
        public virtual Area Area { get; set; }

        [Required]
        public int AnimalClassId { get; set; }
        [ForeignKey("AnimalClassId")]
        public virtual AnimalClass AnimalClass { get; set; }
    }
}
