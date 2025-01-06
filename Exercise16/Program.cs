using Exercise16.Models;

Dictionary<int, GeometricForm> geometricForms = new()
{
    { 1, new Square() },
    { 2, new Circle() }
};

Menu();

void Menu()
{

    Console.WriteLine("Square[1] or Circle[2]? ");
    var option = Convert.ToInt32(Console.ReadLine())!;

    if (geometricForms.ContainsKey(option))
    {
        var element = geometricForms[option];
        element.GetLength();
        element.Area();
        element.Perimeter();
    }
    else
    {
        throw new ArgumentException("Please enter in a valid option...");
    }
}
