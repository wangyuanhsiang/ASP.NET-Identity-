<Query Kind="Program" />

// C# program
//C# primer on nullable - type and extetion methods

void Main() {

int? totalCount = null;
totalCount.Dump();

if(totalCount.HasValue)
{
    "It is has a value".Dump();
}
else
{
  "It doesn't have a value - it is null".Dump();
}
//totalCount = 99;
totalCount.Dump();
}
//Define other meyhods and classes here