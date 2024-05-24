using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace DatabaseERD.Models
{
    public class LeaveRequest
    {
        [Key]
        public Guid RequestID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }


    }
}