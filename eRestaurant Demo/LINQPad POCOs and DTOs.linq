<Query Kind="Program">
  <Connection>
    <ID>92616e0d-d25b-4427-822e-e778fa0610ff</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//POCOs and DTOs

void Main()
{
	 var data = from cat in MenuCategories orderby cat.Description 
	 select new CatagoryDTO() // use the DTO 
	{
	   NewDescription = cat.Description,
	   MenuItem = from item in cat.Items
	   where item.Active orderby item.Description
	   select new MenuItemDTO() //use the DTO
	   {
	      Description = item.Description,
		  price = item.CurrentPrice,
		  Calories = item.Calories,
		  Comment = item.Comment
	   }
	   
	};
	
	data.Dump();
}

// Define other methods and classes here

public class CatagoryDTO// Data- transfer object
{
   public string Description{get; set;}
   public IEnumerable MenuItems {get; set;}
}
public class MenuItemDTO
{
  public string Description {get;set;}
  public decimal Price {get; set;}
  public int? Calories {get; set;}
  public string Comment {get; set;}
}