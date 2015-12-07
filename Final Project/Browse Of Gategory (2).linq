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
	var data = from Category in Categories 
	orderby Category.Description
    select new CategoryPOCOs
    {
	   ID = Category.CategoryID,
       Description = Category.Description,
       ConutItems = (from Item in Category.StockItems select Item.StockItemID).Count()
     };
     
	
	data.Dump();
}

// Define other methods and classes here

public class CategoryPOCOs
{
    public int ID {get; set;}
    public string Description {get; set;}
	public int ConutItems {get; set;}
}