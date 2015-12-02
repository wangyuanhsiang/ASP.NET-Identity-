using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace ScheduleDemo.Entiies
{
     public  class Employee
    {
         [Required(ErrorMessage="Employee ID is required")]
         public int EmployeeID { get; set; }
         [Required, StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 50 characters long.")]
         public string FirstName { get; set; }
         [Required, StringLength(50, MinimumLength = 1, ErrorMessage = "Last name must be between 1 and 50 characters long.")]
         public string LastName { get; set; }
         [Required, DataType(DataType.PhoneNumber, ErrorMessage = "Value must be 10 digital numbers")]
         public string HomePhone { get; set; }
         public bool Active { get; set; }

         public virtual ICollection<Schedule> Schedules { get; set; }
         public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
