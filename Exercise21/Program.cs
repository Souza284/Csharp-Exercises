var numbers = new List<int>{1, 5, 7, 1, 9, 10, 5, 7, 7};

var repeatedNumbers = from n in numbers
                    group n by n into y
                    select y;

foreach(var num in repeatedNumbers)
{
    Console.WriteLine("The number " + num.Key + " appears " + num.Count() + " times");
}