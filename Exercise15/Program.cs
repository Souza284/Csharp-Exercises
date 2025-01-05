var numbers = new List<int> {1, 2, 19, 53, 56, 17, 5, 20, 102, 45};

var oddNumbers = numbers.Where(n => n % 2 == 0);
foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}