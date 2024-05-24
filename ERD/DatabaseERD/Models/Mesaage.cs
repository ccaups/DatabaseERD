using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Message
    {
        [Key]
        public Guid MessageID { get; set; }

        public Guid EmployeeID { get; set; } // Foreign Key 
        [ForeignKey("EmployeeID")]  // Data type should match the Employee table
        public virtual Employee Employee { get; set; }  // Navigation property for accessing the related Employee

        public String Comment { get; set; }

    }
}