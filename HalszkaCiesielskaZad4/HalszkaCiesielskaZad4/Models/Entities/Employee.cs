using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table Employees with properties (columns) 
    /// </summary>
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        [Required]
        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

    }
}
