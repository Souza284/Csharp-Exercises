var cities = new List<string>{"ROME", "LONDON", "PARIS", "ZURICH", "NEW YORK"};

var city = from c in cities
            where c.EndsWith("S") && c.StartsWith("P") || c.EndsWith("E") && c.StartsWith("R")
            select c;

foreach(var c in city)
{
    Console.WriteLine(c);
}