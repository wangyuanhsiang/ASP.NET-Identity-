<Query Kind="Expression">
  <Connection>
    <ID>92616e0d-d25b-4427-822e-e778fa0610ff</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//C# Expression


//from food in Items group food by food.MenuCategoryID into result select result

//from WaiterName in Waiters select WaiterName 

//from Waiter in Waiters group Waiter by Waiter.Phone[780-555-1212]

//from food in Items group food by food.MenuCategory into foodGroup 
//select new {
//Category = foodGroup.Key.Description,
//MenuItem = foodGroup.ToList(),
//Count = foodGroup.Count()
//}

//Key is what we are grouping on

//from Item in Items orderby Item.ItemID select Item

//from cat in MenuCategories orderby cat.Description
//select new {
//Description = cat.Description,
//MenuItems = from Item in cat.Items 
//orderby Item.ItemID select Item 
//}

//from Table in Tables group Table by Table.TableID into TableGroup select TableGroup