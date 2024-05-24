using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class Items
    {
        [Key]
        public Guid ItemID { get; set; }

        public string ItemName { get; set; }

        public int AvailableQuantity { get; set; }

        public int Type { get; set; }

        public DateTime PurchasedDate { get; set; }

        public DateTime LiquidationDate { get; set; }

        public string Description { get; set;}
    }
}