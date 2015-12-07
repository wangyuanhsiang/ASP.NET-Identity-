<Query Kind="Expression">
  <Connection>
    <ID>0e05f424-ac02-4de4-add6-8468a6b0fabf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eTools</Database>
  </Connection>
</Query>

StockItems

from StockItem in StockItems where  StockItem.StockItemID == 35 
select new 
{
   QuantityOnHand = StockItem.QuantityOnHand - 3,
   QuantityOnOrder = StockItem.QuantityOnOrder + 3
}