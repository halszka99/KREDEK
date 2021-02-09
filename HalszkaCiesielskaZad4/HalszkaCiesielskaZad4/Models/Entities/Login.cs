using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalszkaCiesielskaZad4.Models.Entities
{
    /// <summary>
    /// Class to define table Logins with properties (columns) 
    /// </summary>
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Nickname { get; set; }

        [Required]
        [MaxLength(64)]
        public string Password { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
