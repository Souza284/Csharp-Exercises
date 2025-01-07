var rnd = new Random();
var numbers = new List<int>();

for (var i = 0; i < 10; i++)
{
    var sortNumber = rnd.Next(1, 101);
    numbers.Add(sortNumber);
}

foreach(var number in numbers)
{
    Console.Write(number + " ");
}

var greatNumbers = numbers.Where(n => n > 80).ToList();

greatNumbers.Sort();
Console.WriteLine("");

foreach(var number in greatNumbers)
{
    Console.Write(number + " ");
}
