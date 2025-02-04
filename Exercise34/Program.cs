internal class Program
{
    private static void Main(string[] args)
    {
        var fileAddress = "binaryTest.txt";

        using(var fileFlow = Console.OpenStandardInput())
        using(var fileStream = new FileStream(fileAddress, FileMode.Create))
        {
            var buffer = new byte[1024];

            while(true)
            {
                var readBytes = fileFlow.Read(buffer, 0, 1024);

                fileStream.Write(buffer, 0, readBytes);
                fileStream.Flush();

                Console.WriteLine(readBytes);
            }
            
        }
    }
}