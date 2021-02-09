using System.ComponentModel.DataAnnotations;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table Positions with properties (columns) 
    /// </summary>
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public float Salary { get; set; }

    }
}
