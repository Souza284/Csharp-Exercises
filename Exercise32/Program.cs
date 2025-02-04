internal class Program
{
    private static void Main(string[] args)
    {
        var fileAddress = "Accounts.txt";

        using(var fileFlow = new FileStream(fileAddress, FileMode.Open))
        using(var reader = new StreamReader(fileFlow))
        {
            //var text = reader.ReadToEnd();

            //var line = reader.ReadLine();

            //Console.Write(text);
            //Console.WriteLine(line);
        }
    }
}