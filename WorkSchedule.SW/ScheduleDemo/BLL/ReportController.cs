using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ScheduleDemo.Entities.POCOs;
using ScheduleDemo.DAL;
using System.ComponentModel;
namespace ScheduleDemo.BLL
{
      [DataObject]
    public class ReportController
    {
      [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<EmployeeMenu> getReportEmployeeMenu()
        {
            using(var context = new WorkScheduleDBContext() )
            {
                var list = from employee in context.Employees
                          orderby employee.EmployeeID
                          select new EmployeeMenu
                          {
                              EmployeeID = employee.EmployeeID,
                              Name = employee.FirstName + " " + employee.LastName,
                              HomePhone = employee.HomePhone,
                              Active = employee.Active
                          };

                return list.ToList();
            }
        }


          [DataObjectMethod(DataObjectMethodType.Select, false)]
          public List<EmployeeSkillPOCOs> getEmployeeSkillPOCOs()
      {
              using(var context = new WorkScheduleDBContext())
              {
                  var result = from employeeskill in context.EmployeeSkills
                               orderby employeeskill.Employee.LastName
                               select new EmployeeSkillPOCOs()
                               {
                                   Skill = employeeskill.Skill.Description,
                                   Name = employeeskill.Employee.LastName + ", " + employeeskill.Employee.FirstName,
                                   Phone = employeeskill.Employee.HomePhone,
                                   Level = employeeskill.Level.ToString(),
                                   YOE = employeeskill.YearsOfExperience
                               };
                  return result.ToList();
              };
              
      }



    }
}
