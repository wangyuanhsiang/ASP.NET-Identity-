<Query Kind="Program">
  <Connection>
    <ID>0e05f424-ac02-4de4-add6-8468a6b0fabf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eTools</Database>
  </Connection>
</Query>

void Main()
{
	var data = from StockItem in StockItems 
	where StockItem.Category.CategoryID == 4
	&& StockItem.Discontinued == false
    select new StockItemPOCOs 
    {
	  ID = StockItem.Category.CategoryID,
      SellingPrice =  StockItem.SellingPrice,
      Description = StockItem.Description,
      QuantityOnHand = StockItem.QuantityOnHand
    };
   data.Dump();
}

// Define other methods and classes here

public class StockItemPOCOs
{
   public int ID {get; set;}
   public decimal SellingPrice {get; set;}
   public string Description {get; set;}
   public decimal QuantityOnHand {get;set;}
}