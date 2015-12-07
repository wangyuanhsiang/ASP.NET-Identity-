using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eToolsSystem.DAL;
using System.ComponentModel;
using eToolsSystem.Entities;
using eToolsSystem.Entities.POCOs;

namespace eToolsSystem.BLL
{
    [DataObject]
    public class TempaleControll
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Sale> getSales() 
        {
            using(var context = new eToolDBContext())
            {
                return context.Sales.ToList();
            }
            
        }

        #region -- getCategoryBrowse

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<CategoryPOCOs> getCategoryBrowse ()
        {
            using (var context = new eToolDBContext())
            {
                var data = from Category in context.Categories
                           orderby Category.Description
                           select new CategoryPOCOs ()
                           {
                               ID = Category.CategoryID,
                               Description = Category.Description,
                               ConutItems = (from Item in Category.StockItems select Item.StockItemID).Count(),
                           };
              
                return data.ToList();
            }
        }
        #endregion

        #region - getProductMenu

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<StockItemPOCOs> getProductMenu(int id)
        {
            using(var context = new eToolDBContext())
            {

                if (id != 0)
                {

                    var dataA = from StockItem in context.StockItems
                               where StockItem.Category.CategoryID == id
                               && StockItem.Discontinued == false
                               select new StockItemPOCOs
                               {
                                   ID = StockItem.Category.CategoryID,
                                   SellingPrice = StockItem.SellingPrice,
                                   Description = StockItem.Description,
                                   QuantityOnHand = StockItem.QuantityOnHand
                               };
                    return dataA.ToList();
                }
                
                else
                {
                    var dataB = from StockItem in context.StockItems
                                where StockItem.Discontinued == false
                               select new StockItemPOCOs
                               {
                                   ID = StockItem.Category.CategoryID,
                                   SellingPrice = StockItem.SellingPrice,
                                   Description = StockItem.Description,
                                   QuantityOnHand = StockItem.QuantityOnHand
                               };
                    return dataB.ToList();
                }
            }

        }

        #endregion

        #region -- AddToCart
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void AddToCart(  int ProductId, int Quantities)
        {
            //using (var context = new eToolDBContext())
            //{

            //    var data = from StockItem in context.StockItems
            //               //where StockItem.Category.CategoryID == 4
            //               where StockItem.Discontinued == false
            //                   //&& StockItem.Discontinued == false
            //               && StockItem.Description == Description
            //               select new ShappingCartPOCOs
            //               {
            //                   Description = StockItem.Description,
            //                   QuantityOnHand = StockItem.QuantityOnHand - Quantities,
            //                   QuantityOnOrder = StockItem.QuantityOnOrder + Quantities
            //               };
         

            //}

            var context = new eToolDBContext().StockItems.Single(x => x.CategoryID == ProductId);
            context.QuantityOnHand = context.QuantityOnHand - Quantities;
          //  context.QuantityOnOrder = context.QuantityOnOrder + Quantities;
            new eToolDBContext().SaveChanges();
            
           
        }

      
        
        #endregion


    }
}
