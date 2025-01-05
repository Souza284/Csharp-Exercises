namespace Exercise11.Models
{
    internal class BirdCount
    {
        public int[] BirdsPerDay { get; set; }
        public BirdCount(int[] birdsPerDay)
        {
            BirdsPerDay = birdsPerDay;
        }
        public int IncrementTodaysCount() => 1;
        public int Today()
        {
            return BirdsPerDay[^1] + IncrementTodaysCount();
        }

        public bool HasDayWithoutBirds()
        {
            return BirdsPerDay.Contains(0);
        }

        public int CountForFirstDays(int day)
        {
            var sum = 0;

            for (var i = 0; i < day; i++)
            {
                sum += BirdsPerDay[i];
            }
            return sum;
        }
    }
}