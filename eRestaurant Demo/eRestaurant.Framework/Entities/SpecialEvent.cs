using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
     public class SpecialEvent
    {
        [Key]
        [Required (ErrorMessage = "Event code is required")]
        public string EventCode { get; set; }
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "Descriptions must be from 2 to 30 characters in length")]
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public SpecialEvent()
        {
            Active = true;
        }
    }
}
