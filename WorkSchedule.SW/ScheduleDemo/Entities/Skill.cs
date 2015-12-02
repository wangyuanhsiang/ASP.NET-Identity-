using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ScheduleDemo.Entiies
{
    public class Skill
    {
        [Required(ErrorMessage = "Skill id is required")]
        public int SkillID { get; set; }
        [Required, StringLength(100, MinimumLength = 1, ErrorMessage = "Last name must be between 1 and 100 characters long.")]
        public string Description { get; set; }
        public bool RequiresTicket { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
