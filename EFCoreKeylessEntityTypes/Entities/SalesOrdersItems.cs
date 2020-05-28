using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreKeylessEntityTypes.Entities
{
    public class SalesOrdersItems
    {
        [StringLength(10), Key]
        public string SalesOrderItem { get; set; }

        [StringLength(10), Column(nameof(SalesOrder))]
        public string SalesOrderID { get; set; }

        public virtual SalesOrders SalesOrder { get; set; }

        [StringLength(20)]
        public string PartNumber { get; set; }

        public decimal OrderQuantity { get; set; }

        public int UHeight { get; set; }
    }
}