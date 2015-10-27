<Query Kind="Program" />

void Main(){
 var students = Names();
 var lastIntial_s = from person in students where person.Contains(" S") select person;
 lastIntial_s.Dump(" only show the person's name with 'S'  ");
 

}
//Define other methods and classes here

public List <string> Names()
{
List <string> data = new List <string>();
data.Add("Bob Saunders");
data.Add("Shawn Wang");
data.Add("Emily Chen");
data.Add("Anderson Hiso");
data.Add("Bob Wang");

return data;
}
