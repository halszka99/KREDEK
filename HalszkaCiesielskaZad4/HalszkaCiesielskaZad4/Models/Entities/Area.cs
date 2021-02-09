using System.ComponentModel.DataAnnotations;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table Areas with properties (columns) 
    /// </summary>
    public class Area
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
    }
}
