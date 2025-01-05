var numbers = new List<int>(); 

while (true)
{
    Console.WriteLine("Type in a number: ");
    var number = Convert.ToInt32(Console.ReadLine());
    numbers.Add(number);

    Console.WriteLine("Do you want to continue the program? [Yes/No]: ");
    var flag = Console.ReadLine()!;
    flag = flag.ToUpper();

    if (flag == "YES")
    {
        continue;
    }
    else
    {
        break;
    }
}
Console.ReadKey();
Console.Clear();

Console.WriteLine($"Your list of numbers has {numbers.Count} elements");

if (numbers.Contains(5))
{
    Console.WriteLine($"The list contains the number 5 in the position {numbers.IndexOf(5)}");
}
else
{
    Console.WriteLine("The list does not contain the number 5");
}

numbers.Reverse();

Console.WriteLine($"Your inverted list is ");

for (var i = 0; i < numbers.Count; i++)
{
    Console.Write(numbers[i] + " ");
}
