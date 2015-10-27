<Query Kind="Expression">
  <Connection>
    <ID>d68db689-0c61-43d2-989d-26df5147c5ad</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Tables
//from Table in Tables where Table.TableNumber == 11 select Table

//from Table in Tables where Table.Smoking.Equals("True") select Table


//Items

//from food in Items orderby food.Description select food

//from food in Items orderby food.Description ascending select food

//from food in Items orderby food.Description descending select food

//Waiters 

from Waiter in Waiters group Waiter by Waiter.HireDate 