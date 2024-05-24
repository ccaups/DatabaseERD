using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace DatabaseERD.Models
{
    public class Vacation
    {
        [Key]
        public Guid VacationID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Days { get; set; }

        [StringLength(50)]
        public string Reason { get; set; }

        public int Vacation_Days_Balance { get; set; }

    }
}