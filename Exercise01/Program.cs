var numbers = new List<int>(4);

for (var i = 0; i < 4 ; i++)
{
    Console.WriteLine($"Number for position [{i}]:");
    var num = Convert.ToInt32(Console.ReadLine());
    numbers.Add(num);
    //Console.ReadKey();

}

var maxNumber = numbers.Max();
var minNumber = numbers.Min();
Console.Write($"\nThe greatest number is {maxNumber} in the position ");

for (var i = 0; i < numbers.Count; i++) 
{
    //Console.Write("-" + number + "-");
    
    if (numbers[i] == maxNumber)
    {
        Console.Write(i + "..");
    }
}
Console.Write($"\nThe smallest number is {minNumber} in the position ");

for (var i = 0; i < numbers.Count; i++) 
{
    //Console.Write("-" + number + "-");
    
    if (numbers[i] == minNumber)
    {
        Console.Write(i + "..");
    }
}
