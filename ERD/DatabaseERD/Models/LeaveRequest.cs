using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace DatabaseERD.Models
{
    public class LeaveRequest
    {
        [Key]
        public Guid RequestID { get; set; }

        public Guid EmployeeID { get; set; } // Data type should match the Employee table's primary key
        [ForeignKey("EmployeeID")]  // Specifies the relationship to the Employee table
        public virtual Employee Employee { get; set; }  // Navigation property for accessing the related Employee

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }


    }
}