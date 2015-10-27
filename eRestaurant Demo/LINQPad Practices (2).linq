<Query Kind="Expression">
  <Connection>
    <ID>92616e0d-d25b-4427-822e-e778fa0610ff</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//(a) The retaurant Host (who is in charge of the waiters, seats people and takes payments) needs the following information:
//    Show me the reservations slated for a given Year, Month and Day (ignoring the cancelled ones).
//    (For sample dates, choose May 19, 2014 and September 20, 1014).
//    - Advanced: Group the reservations by hour of the day


//(a-1) 

(from Reservation in Reservations where 
(!Reservation.ReservationStatus.Equals("X")) &&
Reservation.ReservationDate.Year == 2014 &&
Reservation.ReservationDate.Month == 05 && 
Reservation.ReservationDate.Day == 19 
select Reservation).Union(
from Reservation in Reservations where
(!Reservation.ReservationStatus.Equals("X")) &&
Reservation.ReservationDate.Year == 2014 &&
Reservation.ReservationDate.Month == 09 &&
Reservation.ReservationDate.Day == 20
select Reservation
)

//(a-2) 
from Reservation in Reservations group Reservation by new { Reservation.ReservationDate.Day, Reservation.ReservationDate.Hour}
into Keys where Keys.Key.Day == 21 select  Keys

//(b) The retaurant Host (who is in charge of the waiters,
//    seats people and takes payments) needs the following information:
//    Waiters with active customers (bills not paid)

from Bill in Bills group Bill by new { Bill.Waiter.FirstName, Bill.Waiter.LastName, Bill.PaidStatus, Bill.Reservation.CustomerName } 
into Keys where Keys.Key.PaidStatus == false select Keys

//(c)The waiters need the following information:
//   Orders waiting to be served (sorted by table and showing the items on the order)

//from Bill in Bills where Bill.OrderServed == null select Bill

from Bill in Bills group Bill by Bill.OrderServed into Keys
where Keys.Key.OrderServed == null select Keys

//(d)The Waiters need the following information:
//   A list of Active tables waiting to place an order



//(e)The Kitchen Staff needs the following information:
//   Items to prepare for orders that have been placed but are not ready, grouped by bill.
//   - Advanced: Include the table number(s) for the bill as a single value (comma-separated table numbers)