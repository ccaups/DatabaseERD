using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Child
    {
        [Key]
        public Guid ChildID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        public string PersonalCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}