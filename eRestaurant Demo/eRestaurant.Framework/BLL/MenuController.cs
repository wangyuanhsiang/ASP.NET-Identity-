using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using eRestaurant.Framework.DAL;
using eRestaurant.Framework.Entities;
using System.Data.Entity;
using eRestaurant.Framework.Entities.DTOs;

namespace eRestaurant.Framework.BLL
{
    [DataObject]
    public class MenuController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<CategoryDTO> ListMenuItem()
        {
            using(var context = new RestaurantContext())
            {
                //return context.Items.ToList();

                var data = from cat in context.MenuCategories
                           orderby cat.Description
                           select new CategoryDTO() // use the DTO 
                           {
                               Description = cat.Description,
                               MenuItems = from item in cat.Items
                                          where item.Active
                                          orderby item.Description
                                          select new MenuItemDTO() //use the DTO
                                          {
                                              Description = item.Description,
                                              Price = item.CurrentPrice,
                                              Calories = item.Calories,
                                              Comment = item.Comment
                                          }

                           };
                return data.ToList();
            }
            
        }
    }
}
