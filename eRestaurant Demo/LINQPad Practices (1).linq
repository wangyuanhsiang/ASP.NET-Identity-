<Query Kind="Expression">
  <Connection>
    <ID>d68db689-0c61-43d2-989d-26df5147c5ad</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//from Reservation in Reservations group Reservation by 
//(!Reservation.ReservationStatus.Equals("X")) &&
//Reservation.ReservationDate.Year == 2014 &&
//Reservation.ReservationDate.Month == 05 && 
//Reservation.ReservationDate.Day == 25 into selectKey
//where selectKey.Key == true select selectKey

//from Reservation in Reservations group new { 
//Reservation.ReservationDate.Day  , Reservation.ReservationDate.Hour } by Reservation

//from Reservation in Reservations orderby Reservation.ReservationDate.Hour select Reservation


from Bill in Bills group Bill by new { Bill.Waiter.FirstName, Bill.Waiter.LastName, Bill.PaidStatus, Bill.Reservation.CustomerName } 
into Keys where Keys.Key.PaidStatus == false select Keys