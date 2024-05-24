using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Message
    {
        [Key]
        public Guid MessageID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        public String Comment { get; set; }

    }
}