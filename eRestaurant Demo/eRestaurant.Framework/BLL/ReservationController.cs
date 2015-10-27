using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using eRestaurant.Framework.DAL;
using eRestaurant.Framework.Entities.POCOs;

namespace eRestaurant.Framework.BLL
{
    #region - Dropdown List
    [DataObject]
     public  class ReservationController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ActiveEvent> listActiveEvents()
        {
            using (var context = new RestaurantContext())
            {
                var result = from eachRow in context.SpecialEvents
                             where eachRow.Active //== true
                             select new ActiveEvent
                             {
                                 Code = eachRow.EventCode,
                                 Description = eachRow.Description
                             };
                return result.ToList();
            }

        }
       #endregion
        //#region - list Upcoming reservation 
        //   [DataObjectMethod(DataObjectMethodType.Select, false)]

        //#endregion


    }
}
