Console.WriteLine("Enter the height: ");
var height = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the width: ");
var width = Convert.ToDecimal(Console.ReadLine());

area(height, width);

static void area(decimal X, decimal Y)
{
    var area = X*Y;
    Console.WriteLine($"The area is {area}");
}
