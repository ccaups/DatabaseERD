using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Title
    {
        [Key]
        public Guid TitleID { get; set; }

        [ForeignKey("EmployeeID")]  // Foreign Key 
        public Guid EmployeeID { get; set; } // Data type should match the Employee table
        public virtual Employee Employee { get; set; } // Navigation property for accessing the related Employee

        [StringLength(50)]
        public string TitleName { get; set; }


    }
}