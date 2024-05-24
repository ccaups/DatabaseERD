using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class AccessPermission
    {
        [Key]
        public Guid AccessPermissionsID { get; set; }

        [ForeignKey("EmployeeID")]  // Foreign Key 
        public Guid EmployeeID { get; set; } // Data type should match the Employee table
        public Employee Employee { get; set; }  // Navigation property for accessing the related Employee

        public string AccessLevels { get; set; }


    }
}