using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class ItemLoan
    {
        [Key]
        public Guid LoanID { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        [ForeignKey("Items")]
        public Guid ItemID { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Comment { get; set; }
    }
}