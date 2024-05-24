using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class ItemLoan
    {
        [Key]
        public Guid LoanID { get; set; }

        // Foreign Key relationship with Employee
        public Guid EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; } // Navigation property

        // Foreign Key relationship with Item
        public Guid ItemID { get; set; }
        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; } // Navigation property

        [Required]  // Required field
        public DateTime LoanDate { get; set; }

        public DateTime? ReturnDate { get; set; } // Nullable return date

        [StringLength(200)] // Limits comment length
        public string Comment { get; set; }
    }
}