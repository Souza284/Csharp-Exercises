internal class Program
{
    private static void Main(string[] args)
    {
        var fileAddress = "_test.txt";

        File.WriteAllText(fileAddress, "Pedro Souza");
    }
}