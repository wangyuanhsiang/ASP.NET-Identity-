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
                               AllItems = 0
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
                                   StockItemID = StockItem.StockItemID,
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
                                   StockItemID = StockItem.StockItemID,
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
     
        public void AddToCart(  int ProductId, int Quantities)
        {

            eToolDBContext ShoppingCartHeart = new eToolDBContext();

            var cartItem = ShoppingCartHeart.ShoppingCartItems.SingleOrDefault(x => x.StockItem.StockItemID == ProductId && x.ShoppingCartID == ProductId);
            if(cartItem == null)
            {
                cartItem = new ShoppingCartItem
                {
                    ShoppingCartID = ProductId,
                    StockItemID = ProductId,
                    Quantity = Quantities
                };
                ShoppingCartHeart.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                Quantities = cartItem.Quantity + Quantities;
            }
            ShoppingCartHeart.SaveChanges();

            //var cartItem = addData.StockItems.Single(x => x.StockItemID == ProductId);
            //cartItem = new StockItem
            //{
            //    StockItemID = ProductId,
            //    Description = cartItem.Description,
            //    SellingPrice = cartItem.SellingPrice,
            //    PurchasePrice = cartItem.PurchasePrice,
            //    QuantityOnHand = cartItem.QuantityOnHand,
            //    QuantityOnOrder = Quantities,
            //    ReOrderLevel = cartItem.ReOrderLevel,
            //    Discontinued = cartItem.Discontinued,
            //    VendorID = cartItem.VendorID,
            //    VendorStockNumber = cartItem.VendorStockNumber,
            //    CategoryID = cartItem.CategoryID
            //};

            //addData.StockItems.Add(cartItem);

            //addData.SaveChanges();

        }
        #endregion

        #region - AddToOnlineCustomer
        public void AddToOnlineCustomer(Guid TrC ,string Name)
        {
             using(var context = new eToolDBContext())
             {
                    var Customer = context.OnlineCustomers.SingleOrDefault(x =>  x.TrackingCookie == TrC );
                    if (Customer == null)
                    {
                        Customer = new OnlineCustomer
                        {
                            //OnlineCustomerID = ID,
                            UserName = Name,
                            CreatedOn = DateTime.Now,
                        };
                        context.OnlineCustomers.Add(Customer);
                        context.SaveChanges();
                    }
                     
   
                  
             }
             
        }
        #endregion

    }
}
