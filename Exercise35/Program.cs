internal class Program
{
    private static void Main(string[] args)
    {
        BinaryWriter();
        BinaryReader();
    }

    static void BinaryWriter()
    {
        var fileAddress = "test.txt";

        using (var fileStream = new FileStream(fileAddress, FileMode.Create))
        using (var writer = new BinaryWriter(fileStream))
        {
            writer.Write("Pedro Souza");
            writer.Write(18);
        }
    }

    static void BinaryReader()
    {
        var fileAddress = "test.txt";

        using (var fileStream = new FileStream(fileAddress, FileMode.Open))
        using (var reader = new BinaryReader(fileStream))
        {
            var name = reader.Read();
            var age = reader.ReadInt32();

            Console.WriteLine(name + " " + age);
        }
    }
}