<Query Kind="Expression">
  <Connection>
    <ID>d68db689-0c61-43d2-989d-26df5147c5ad</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>


//from Waiter in Waiters where Waiter.FirstName.StartsWith("B") select Waiter 
//from Waiter in Waiters where Waiter.FirstName.EndsWith("y") select Waiter 
from Waiter in Waiters where Waiter.FirstName.StartsWith("B") && Waiter.LastName.EndsWith("ts") select Waiter 

//Waiters