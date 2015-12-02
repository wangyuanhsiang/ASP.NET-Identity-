using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ScheduleDemo.Entiies
{
     public class Location
    {
         public int LocationID { get; set; }
         [Required, StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters long.")]
         public string Name { get; set; }
         [Required, StringLength(50, MinimumLength = 1, ErrorMessage = "Street must be between 1 and 50 characters long.")]
         public string Street { get; set; }
         [Required, StringLength(30, MinimumLength = 1, ErrorMessage = "City must be between 1 and 30 characters long.")]
         public string City { get; set; }
         [Required, StringLength(2, MinimumLength = 2, ErrorMessage = "Provine value must be 2 characters. ")]
         public string Province { get; set; }
        // [Required, StringLength(50, MinimumLength = 1, ErrorMessage = "Contact must be between 1 and 50 characters long.")]
         public string Contact { get; set; }
         [Required, DataType(DataType.PhoneNumber, ErrorMessage = "Value must be 10 digital numbers")]
         public string Phone { get; set; }
         public bool Active { get; set; }

         public virtual ICollection<PlacementContract> PlacementContracts { get; set; }


         public Location()
         { Active = true; }


       

    }
}
