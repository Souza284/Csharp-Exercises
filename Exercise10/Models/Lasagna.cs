namespace Exercise10.Models
{
    internal class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutesInOven(int minutes)
        {
            return ExpectedMinutesInOven() - minutes;
        }

        public int PreparationTimeMinutes(int layers)
        {
            return layers * 2;
        }

        public int ElapsedTimeInMinutes(int layers, int time)
        {
            return PreparationTimeMinutes(layers) + time;
        }
    }
}