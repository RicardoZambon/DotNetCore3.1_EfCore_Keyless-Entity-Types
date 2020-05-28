using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreKeylessEntityTypes.Entities
{
    public class AvailablePartsKeyless
    {
        public string SalesOrder { get; set; }

        public string SalesOrderItem { get; set; }

        public string QNumber { get; set; }

        public string PartNumber { get; set; }

        public decimal OrderQuantity { get; set; }

        public int UHeight { get; set; }
    }
}
