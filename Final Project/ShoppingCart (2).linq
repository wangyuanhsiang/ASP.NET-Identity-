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
	//where StockItem.Category.CategoryID == 4
	where StockItem.Discontinued == false
	//&& StockItem.Discontinued == false
	&& StockItem.Description == "Dewalt Multi Speed Drill"
    select new ShappingCartPOCOs 
    {
      Description = StockItem.Description,
	  QuantityOnHand = StockItem.QuantityOnHand - 3,
      QuantityOnOrder = StockItem.QuantityOnOrder + 3
    };
   data.Dump();
}

// Define other methods and classes here

public class ShappingCartPOCOs
{
   public string Description {get; set;}
   public int QuantityOnHand {get;set;}
   public int QuantityOnOrder {get;set;}
}