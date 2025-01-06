namespace Exercise17.Models
{
    internal class SMS : INotifiable
    {
        public void ISendNotification()
        {
            Console.WriteLine("Sending SMS notification...");
        }
    }
}