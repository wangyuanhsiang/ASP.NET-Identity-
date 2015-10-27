using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities.DTOs
{
    public class DailyReservation
    {
        public DateTime Month { get; set; }
        public DateTime Day { get; set; }
        public IEnumerable<Booking> Reservations { get; set; }
    }
}
