var numbers = new List<int> {1, 2, 19, 53, 56, 17, 5, 20, 102, 45};

var evenNumber = numbers.Where(n => n % 2 == 1);

foreach (var number in evenNumber)
{
    Console.WriteLine(number);
}