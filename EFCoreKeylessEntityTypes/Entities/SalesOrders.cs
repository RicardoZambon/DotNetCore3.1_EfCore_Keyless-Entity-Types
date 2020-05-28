using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreKeylessEntityTypes.Entities
{
    public class SalesOrders
    {
        [StringLength(10), Key]
        public string SalesOrder { get; set; }

        [StringLength(10)]
        public string QNumber { get; set; }

        public virtual QLink QLink { get; set; }


        public virtual ICollection<SalesOrdersItems> SalesOrdersItems { get; set; }

    }
}