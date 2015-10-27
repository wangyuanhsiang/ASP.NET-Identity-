<Query Kind="Program" />

//C# program
void Main(){
//string name = "Dan";
int number = 6;
//string messeage = name.Sleepy();
string messeage = number.Sleepy();
messeage.Dump();
}


public static class StringExtention{

public static string Sleepy(this string text){
    
    return text = "hello world";
}

public static string Sleepy(this int hours){
//string text = null;
if (hours <= 3)
{
return  "not enough";
}
else if (hours >= 4 && hours <= 7)
{
return  "should sleep more";
}
else
{
return  "too much";
}
}


}