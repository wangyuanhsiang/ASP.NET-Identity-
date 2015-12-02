using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ScheduleDemo.DAL; // 
using ScheduleDemo.Entiies;


namespace ScheduleDemo.BLL
{
     [DataObject]
    public class ScheduledemoController
    {
        #region - Employees Control
        public List<Employee> ListEmployee()
        {
            using (WorkScheduleDBContext EmployeeDBContext = new WorkScheduleDBContext() )
            { return EmployeeDBContext.Employees.ToList(); }

        }

        #region - Employees Query
        #region - Employees Query (Insert)
        [DataObjectMethod(DataObjectMethodType.Insert, false)] 
         public void AddEmployeeInfo (Employee Entities)
        {
             using(var context = new WorkScheduleDBContext())
             { var adding = context.Employees.Add(Entities); context.SaveChanges(); }
        }

        #endregion

        #region - Employees Query (Update)
        [DataObjectMethod(DataObjectMethodType.Update, false)]
         public void UpdateEmployeeInfo (Employee Entityies)
        {
             using(var context = new WorkScheduleDBContext())
             {
                 var updating = context.Employees.Attach(Entityies);
                 var matchingWithExistingValues = context.Entry<Employee>(updating);
                 matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                 context.SaveChanges();
             }
        }
        #endregion

        #region - Employees Query (Delete)
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
        #endregion

        #endregion
        #endregion

        #region - Location manager
         #region - Location List
         public List<Location> ListLocation()
         {
             using(var LocationDBContext = new WorkScheduleDBContext())
             {
                 return LocationDBContext.Locations.ToList();
             }

         }
         #endregion
        #region - Location Query
         
           #region - Location Query (Insert)
         [DataObjectMethod(DataObjectMethodType.Insert, false)]
           public void AddLocationInfo (Location Entities)
         {
             using (var context = new WorkScheduleDBContext())
             { var adding = context.Locations.Add(Entities); context.SaveChanges(); }
         }
           #endregion

           #region - Location Query (Update)
         [DataObjectMethod(DataObjectMethodType.Update, false)]
         public void UpdateLocationInfo(Location Entities)
         {
             using (var context = new WorkScheduleDBContext())
             { 
                 var updating = context.Locations.Attach(Entities);
                 var matchingWithExistingValues = context.Entry<Location>(updating);
                 matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                 context.SaveChanges();
             }
         }
         #endregion

        #endregion
            


        #endregion

    }
}
