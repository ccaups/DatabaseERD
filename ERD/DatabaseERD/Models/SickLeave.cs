using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class SickLeave
    {
        [Key]
        public Guid LeaveID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime Days { get; set; }

        public String Description { get; set; }

    }
}