using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class HealthCheck
    {
        [Key]
        public Guid CheckID { get; set; }

        [ForeignKey("EmployeeID")] // Foreign Key 
        public Guid EmployeeID { get; set; }  // Data type should match the Employee table
        public virtual Employee Employee { get; set; }  // Navigation property for accessing the related Employee

        public DateTime CheckDate { get; set; }

        public String Results{ get; set; }

    }
}