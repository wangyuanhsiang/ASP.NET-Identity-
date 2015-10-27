<Query Kind="Expression">
  <Connection>
    <ID>92616e0d-d25b-4427-822e-e778fa0610ff</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//C# Expression

//(from customer in BillItems where customer.BillID == 104 select customer.SalePrice *  customer.Quantity).Sum()

//from customer in Bills
//where customer.BillDate.Year == 2014
//   && customer.BillDate.Month == 05
//   && customer.BillDate.Day == 25
//select customer

from info in Bills where info.BillDate.Month > 05 && info.BillDate.Month < 08 && info.NumberInParty > 10  select info