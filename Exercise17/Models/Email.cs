namespace Exercise17.Models
{
    internal class Email : INotifiable
    {
        public void ISendNotification()
        {
            Console.WriteLine("Sending email notification...");
        }
    }
}