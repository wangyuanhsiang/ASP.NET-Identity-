using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Framework.Entities
{
     public class Waiter
    {
         [Required (ErrorMessage = "Waiter Id is required")]
         public int WaiterID { get; set;}
         [Required(ErrorMessage = "First name is required")]
         public string FirstName { get; set; }
         [Required(ErrorMessage = "Last name is required")]
         public string LastName { get; set; }
         [Required, DataType(DataType.PhoneNumber, ErrorMessage = "Value must be a phone number")]
         public string Phone { get; set; }
         [Required, DataType(DataType.PostalCode, ErrorMessage = "Value must be a Post code")]
         public string Address { get; set; }
         [Required, DataType(DataType.DateTime, ErrorMessage = "Value must be datetime")]
         public DateTime HireDate { get; set; }
         public DateTime? ReleaseDate { get; set; }

         public virtual ICollection<Bill> Bills { get; set; }
    }
}
