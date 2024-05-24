using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class HealthCheck
    {
        [Key]
        public Guid CheckID { get; set; }

        public Guid EmployeeID { get; set; } // Data type should match the Employee table's primary key
        [ForeignKey("EmployeeID")]  // Specifies the relationship to the Employee table
        public virtual Employee Employee { get; set; }  // Navigation property for accessing the related Employee

        public DateTime CheckDate { get; set; }

        public String Results{ get; set; }

    }
}