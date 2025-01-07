var cities = new List<string>{"ROME", "LONDON", "PARIS", "ZURICH", "NEW YORK"};

/*var city = from c in cities
            where c.EndsWith("S") && c.StartsWith("P") || c.EndsWith("E") && c.StartsWith("R")
            select c;*/

var city = cities.Where(c => c.StartsWith("R") && c.EndsWith("E")).ToList();

foreach(var c in city)
{
    Console.WriteLine(c);
}