using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Child
    {
        [Key] // Marks ChildID as the primary key
        public Guid ChildID { get; set; } = Guid.NewGuid(); // Auto-generate a GUID for new children

        // Foreign Key (FK) Relationship
        public Guid EmployeeID { get; set; } // Data type should match the Employee table's primary key
        [ForeignKey("EmployeeID")]  // Specifies the relationship to the Employee table
        public virtual Employee Employee { get; set; }  // Navigation property for accessing the related Employee

        public string PersonalCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}