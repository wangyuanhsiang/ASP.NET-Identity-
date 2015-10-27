using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace eRestaurant.Framework.Entities
{
    public class Table
    {
        public int TableID { get; set; }
        [Required,  Range (1, 25, ErrorMessage = "Table Number must be between 1 to 25") ]
        //[Range (1, 8)]
        public Byte TableNumber { get; set; }
        public Boolean Smoking { get; set; }
        [Range(1,8,  ErrorMessage ="1 to 8" )]
        public int Capacity { get; set; }
        public Boolean Available { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public Table()
        {
            Available = true;
            Smoking = false;
        }
    }
}
