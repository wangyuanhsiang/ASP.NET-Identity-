using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ScheduleDemo.Entiies
{
     public class Schedule
    {
         [Required(ErrorMessage ="Schedule ID is reqiured")]
         public int ScheduleID { get; set; }
         public DateTime Day { get; set; }
         public int ShiftID { get; set; }
         public int EmployeeID { get; set; }

         public virtual Shift Shift { get; set; }
         public virtual Employee Employee { get; set; }
        
    }
}
