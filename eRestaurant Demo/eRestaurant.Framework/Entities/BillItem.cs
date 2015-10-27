using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Framework.Entities
{
     public class BillItem
    {
         [Key]
         [Required(ErrorMessage = "Bill Id is required")]
         public int BillID { get; set; }
         public int ItemID { get; set; }
         public int Quantity { get; set; }
         public Decimal SalePrice { get; set; }
         public Decimal UnitCost { get; set; }
         public string Notes { get; set; }

         public virtual Bill Bill { get; set; }
         public virtual Item Item { get; set; }


     }
}
