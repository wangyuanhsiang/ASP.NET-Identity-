using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace ScheduleDemo.Entiies
{
    public class PlacementContract
    {
        [Required(ErrorMessage = " PlacementContractID is required")]
        public int PlacementContractID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationID { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
