using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToolsSystem.Entities.POCOs
{
    public class StockItemPOCOs
    {
        public int ID { get; set; }
        public decimal SellingPrice { get; set; }
        public string Description { get; set; }
        public int QuantityOnHand { get; set; }
    }
}
