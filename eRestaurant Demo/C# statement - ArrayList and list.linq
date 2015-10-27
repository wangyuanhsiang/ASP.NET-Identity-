<Query Kind="Statements">
  <Connection>
    <ID>92616e0d-d25b-4427-822e-e778fa0610ff</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//C# Statment
//var result = from Item in Items where Item.MenuCategoryID > 3 select Item;
//result.Dump();


//var Names = from Waiter in Waiters where Waiter.FirstName.StartsWith("B") select Waiter;
//Names.Dump();

//create a String array list 
//ArrayList names = new ArrayList();
//names.Add("Shawn");
//names.Add("Emily");
//names.Add("Don");
//names.Dump();

//create a list

List<string> list = new List<string>();
list.Add("Shawn");
list.Add("Emily");
list.Add("Don");
list.Add("Vicky"); list.Dump();

var names = from person in list where person.StartsWith("S") select person;
names.Dump();