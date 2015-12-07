<Query Kind="Expression">
  <Connection>
    <ID>0e05f424-ac02-4de4-add6-8468a6b0fabf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eTools</Database>
  </Connection>
</Query>

from Category in Categories 
select new
{
   Description = Category.Description,
   ConutItems = (from Item in Category.StockItems select Item.StockItemID).Count()
}

// count all items

(from allItems in StockItems select allItems.StockItemID).Count()

