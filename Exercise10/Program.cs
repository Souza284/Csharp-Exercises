using Exercise10.Models;

var lasagna = new Lasagna();

Console.WriteLine("Expected minutes in oven: " + lasagna.ExpectedMinutesInOven());

Console.WriteLine("Actual minutes the lasagna has been in oven: " + lasagna.RemainingMinutesInOven(30));

Console.WriteLine("You spend " + lasagna.PreparationTimeMinutes(2) + " minutes to prepare the lasagna.");

Console.WriteLine("You have spent " + lasagna.ElapsedTimeInMinutes(3, 20) +  " minutes cooking the lasagna.");
