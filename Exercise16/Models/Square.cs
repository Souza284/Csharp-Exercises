namespace Exercise16.Models
{
    internal class Square : GeometricForm
    {
        public int Side { get; set; }
        public override void GetLength()
        {
            Console.WriteLine("Enter in the side: ");
            Side = Convert.ToInt32(Console.ReadLine());
        }
        public override void Area()
        {
            Console.WriteLine(Side * Side);
        }
        public override void Perimeter()
        {
            Console.WriteLine(Side * 4);
        }
    }
}