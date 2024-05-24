using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Title
    {
        [Key]
        public Guid TitleID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        [StringLength(50)]
        public string TitleName { get; set; }


    }
}