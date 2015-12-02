using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ScheduleDemo.DAL;
using ScheduleDemo.Entiies;
using ScheduleDemo.Entities.POCOs;

namespace ScheduleDemo.BLL
{
    [DataObject]
    public class ListViewController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<DropDwonListPOCOs> getDropDwonList()
        {
            using(var context = new WorkScheduleDBContext())
            {
                var data = from EmployeeSkill in context.EmployeeSkills
                           select new DropDwonListPOCOs
                           {
                               ID = EmployeeSkill.EmployeeID,
                               Descripotion = EmployeeSkill.Skill.Description
                           };
                return data.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Employee> getEmployeeList(int id)
        {
            using(var context = new WorkScheduleDBContext())
            {
                var data = from Employee in context.Employees where Employee.EmployeeID == id select Employee;
                return data.ToList();
            }
        }
         [DataObjectMethod(DataObjectMethodType.Insert, false)] 
         public void AddEmployeeInfo (Employee Entities)
        {
              using(var context = new WorkScheduleDBContext())
              { var adding = context.Employees.Add(Entities); context.SaveChanges(); }
        }

          [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateEmployeeInfo(Employee Entities)
        {
              using (var context = new WorkScheduleDBContext())
              {
                  var updating = context.Employees.Attach(Entities);
                  var matchingWithExistingValues = context.Entry<Employee>(updating);
                  matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                  context.SaveChanges();
              }
        }


        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteEmployeeInfo (Employee Entities)
          {
            using(var context = new WorkScheduleDBContext())
            {
                var existingvalue = context.Employees.Find(Entities.EmployeeID);
                context.Employees.Remove(existingvalue);
                context.SaveChanges();
            }
          }

    } //   public class ListViewController
}
