using System.ComponentModel.DataAnnotations;

namespace DatabaseERD.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeID { get; set; }

        [Required(ErrorMessage = "Personal code is required")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Invalid personal code format (XXXXXXXXXXX)")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Personal code must be exactly 11 digits")]
        public string PersonalCode { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }
    }
}
