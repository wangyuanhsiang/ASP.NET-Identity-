using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace ScheduleDemo.Entiies
{
    public class Shift
    {
        [Required(ErrorMessage="Shift ID is required")]
        public int ShiftID { get; set; }
        public int PlacementContractID { get; set; }
        public int DayOfWeek { get; set; }
        public DateTime StartTime { get; set;}
        public DateTime EndTime { get; set; }
        public Byte NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        [Required, StringLength(100, MinimumLength = 1, ErrorMessage = "Notes must be between 1 and 50 characters long.")]
        public string Notes { get; set; }

        public virtual PlacementContract PlacementContract { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }  
    }
}
