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
    public class RestaurantAdminController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiter> getAllWaiters ()
        { using (var context = new RestaurantContext()) return context.Waiters.ToList(); }

    }
}
