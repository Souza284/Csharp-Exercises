using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string fileAddress = "Accounts.txt";

        int byteNumber = -1;

        FileStream fileFlow = new FileStream(fileAddress, FileMode.Open);

        byte[] buffer = new byte[1024];

        while (byteNumber != 0)
        {
            byteNumber = fileFlow.Read(buffer, 0, 1024);
            //Console.WriteLine(byteNumber);
        }

        WriteText(buffer, byteNumber);
    }

    static void WriteText(byte[] buffer, int byteNumber)
    {
        UTF8Encoding utf8 = new UTF8Encoding();

        string text = utf8.GetString(buffer);

        Console.Write(text);
    }
}