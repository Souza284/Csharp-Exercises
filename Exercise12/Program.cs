int[] numbers = {7, 36, 402, 6, 24, 147, 74, 620, 25, 5, 36, 174, 6};

var numbersDistinct = numbers.Distinct();

foreach (var number in numbersDistinct)
{
    Console.WriteLine(number);
}
