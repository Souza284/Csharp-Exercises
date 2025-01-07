var numbers = new List<int>{1,3,5,7,9};

/*var squareNumbers = numbers.Select(n => n * n);

foreach(var number in squareNumbers)
{
    Console.WriteLine(number);
}*/

var squareNumbers = from int number in numbers
                    let _squareNumbers = number * number
                    select new {number, _squareNumbers};