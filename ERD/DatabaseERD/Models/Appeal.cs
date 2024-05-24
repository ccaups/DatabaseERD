using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Appeal
    {
        [Key]
        public Guid AppealID { get; set; }

        public String Comment { get; set; }

    }
}