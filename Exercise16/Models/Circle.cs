using System.Net.NetworkInformation;

namespace Exercise16.Models
{
    internal class Circle : GeometricForm
    {
        public double Radium { get; set; }
        public override void GetLength()
        {
            Console.WriteLine("Enter in the radium: ");
            Radium = Convert.ToDouble(Console.ReadLine());
        }
        public override void Area()
        {
            Console.WriteLine(Math.PI * Math.Pow(Radium, 2));
        }
        public override void Perimeter()
        {
            Console.WriteLine(Math.PI * 2 * Radium);
        }
    }
}