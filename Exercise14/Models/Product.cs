namespace Exercise14.Models
{
    internal class Product
    {
        public decimal Price { get; set; }
        public string? Name { get; set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}