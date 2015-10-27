<Query Kind="Expression">
  <Connection>
    <ID>92616e0d-d25b-4427-822e-e778fa0610ff</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//CQRS

//from cat in MenuCategories orderby cat.Description select new
//{
//   NewDescription = cat.Description,
//   MenuItem = from item in cat.Items
//   where item.Active orderby item.Description select new
//   {
//      Description = item.Description,
//	  price = item.CurrentPrice,
//	  Calories = item.Calories,
//	  Comment = item.Comment
//   }
//   
//}