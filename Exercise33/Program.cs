internal class Program
{
    private static void Main(string[] args)
    {
        var fileAddress = "test.txt";

        using(var fileFlow = new FileStream(fileAddress, FileMode.Create))
        using(var creator = new StreamWriter(fileFlow))
        {
            creator.WriteLine(false);
            creator.WriteLine("Pedro/" + 18 + "/Student");
            creator.WriteLine(90.2);
        }
    }
}