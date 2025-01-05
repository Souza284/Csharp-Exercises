var numbers = new List<int>(); //list witch contains the numbers. obs: they can only be insert once

while (true)
{
    Console.ForegroundColor = ConsoleColor.White; //It returns the text color to white
    Console.WriteLine("Type in a number: ");
    var number = Convert.ToInt32(Console.ReadLine()); 

    if (numbers.Contains(number)) //if there is this number in the list, it won't be add again
    {
        Console.ForegroundColor = ConsoleColor.Red; // It changes the text color to red
        Console.WriteLine("Duplicate number. I won't add it...");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green; // It changes the text color to green
        Console.WriteLine("Number added successfully."); //if the is not this number in the list, it will be add
        numbers.Add(number);
    }

    Console.ReadKey();

    Console.ForegroundColor = ConsoleColor.White; //It returns the text color to white
    Console.WriteLine("Do you want to stop the program? [Yes/No]:");
    var flag = Console.ReadLine()!; //variable created to indicate if the user wants to stop the program or not
    flag = flag.ToUpper();

    if (flag == "YES")
    {
        break;
    }
    else
    {
        continue;
    }
}
Console.ForegroundColor = ConsoleColor.White; //It returns the text color to white
Console.Write("The list you have created is [ ");

numbers.Sort(); // It will order the list

foreach(var number in numbers)
{
    Console.Write($"{number} ");
}
Console.Write("]");
