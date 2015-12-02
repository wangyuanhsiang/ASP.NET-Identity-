using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ScheduleDemo.Entities.DTOs;
using ScheduleDemo.DAL;


namespace ScheduleDemo.BLL
{
    [DataObject]
    public class RepeatersController
    {
        #region - Employee List
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SkillDTO> ListEmployees() 
        {
            using(var context = new WorkScheduleDBContext())
            {
                var result = from Skill in context.Skills
                             orderby Skill.Description
                             where Skill.Description.EndsWith("Journeyman")
                             select new SkillDTO
                             {
                                 Description = Skill.Description,
                                 Employees = from EmployeeSkill in Skill.EmployeeSkills
                                             orderby EmployeeSkill.YearsOfExperience descending
                                             select new EmployeeDTO
                                             {
                                                 Name = EmployeeSkill.Employee.FirstName + "  " + EmployeeSkill.Employee.LastName,
                                                 //Level = EmployeeSkill.Level.ToString(),
                                                 YearsExperience = EmployeeSkill.YearsOfExperience

                                             }
                             };
                return result.ToList();
            }    
        }

        #endregion
    }
}
