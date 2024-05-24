using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class HealthCheck
    {
        [Key]
        public Guid CheckID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        public DateTime CheckDate { get; set; }

        public String Results{ get; set; }

    }
}