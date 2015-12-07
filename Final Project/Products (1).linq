<Query Kind="Expression">
  <Connection>
    <ID>9a250d5e-dbd0-445e-aecd-7b07607ce211</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eTools</Database>
  </Connection>
</Query>

from StockItem in StockItems 
select new 
{
  SellingPrice =  StockItem.SellingPrice,
  Description = StockItem.Description,
  QuantityOnHand = StockItem.QuantityOnHand
}
