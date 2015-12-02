using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDemo.Entities.DTOs
{
     public class SkillDTO
    {
        public string Description { get; set; }
        public IEnumerable<EmployeeDTO> Employees { get; set; }
    }
}
