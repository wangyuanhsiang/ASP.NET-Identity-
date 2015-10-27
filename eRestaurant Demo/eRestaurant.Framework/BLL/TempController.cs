using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using eRestaurant.Framework.Entities;
using eRestaurant.Framework.DAL;

namespace eRestaurant.Framework.BLL
{
     [DataObject]

     public class TempController
     {
         #region manage special events
         [DataObjectMethod(DataObjectMethodType.Select, false)]
         public List<SpecialEvent> ListSpecialEvent()
         {
             using (RestaurantContext specialEventDBContext = new RestaurantContext())
             { return specialEventDBContext.SpecialEvents.ToList(); }
         }

         [DataObjectMethod(DataObjectMethodType.Select, false)]
         public void getSpecialEvent(int ID)
         {
              using (RestaurantContext specialEventDBContext = new RestaurantContext())
              {
                  specialEventDBContext.SpecialEvents.Find(ID);
              }
         }


         [DataObjectMethod(DataObjectMethodType.Insert, false)]
         public void AddSpecialEvent(SpecialEvent Entities)
         {
             using (RestaurantContext specialEventDBContext = new RestaurantContext())
             { var adding = specialEventDBContext.SpecialEvents.Add(Entities); specialEventDBContext.SaveChanges(); }
         }

         [DataObjectMethod(DataObjectMethodType.Update, false)]
         public void UpdateSpecialEvent (SpecialEvent Entities)
         {       
            using(RestaurantContext specialEventDBContext = new RestaurantContext())
            { var updating = specialEventDBContext.SpecialEvents.Attach(Entities);
            var matchingWithExistingValues = specialEventDBContext.Entry<SpecialEvent>(updating);
            matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
            specialEventDBContext.SaveChanges();
            }
         
         }

         [DataObjectMethod(DataObjectMethodType.Delete, false)]
         public void DeleteSpecialEvent(SpecialEvent Entities)
         {
             using(RestaurantContext specialEventDBContext = new RestaurantContext())
             {
                 var existingvalue = specialEventDBContext.SpecialEvents.Find(Entities.EventCode);
                 // remember to add the DataKeyNames for delete and update
                 specialEventDBContext.SpecialEvents.Remove(existingvalue);
                 specialEventDBContext.SaveChanges();
             }
         }

         #endregion

     }


}
