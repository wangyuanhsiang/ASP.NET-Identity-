using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
     public class Reservation
    {

         public const string Booked = "B";
         public const string Complete = "C";
         public const string NoShow = "N";
         public const string Cancelled = "X";

         //[Key]
         [Required(ErrorMessage= "Reservation Id is Required")]
         public int ReservationID { get; set; }
         public string CustomerName { get; set; }
         public DateTime ReservationDate { get; set; }
         public int NumberinParty { get; set; }
         public string ContactPhone {get;set;}
         public string ReservationStatus { get; set; }
         public string EventCode { get; set; }
         
         public virtual SpecialEvent SpecialEvent {get; set;}

         public virtual ICollection<Table> Tables { get; set;}
         public virtual ICollection<Bill> Bills { get; set; }
    }
}
