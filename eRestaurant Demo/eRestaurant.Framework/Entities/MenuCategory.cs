using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    public class MenuCategory
    {
       //  [Key]
        [Required(ErrorMessage="MenuCategory Id is required")]
        public int MenuCategoryID { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Item> Items { get; set;}
    }
}
