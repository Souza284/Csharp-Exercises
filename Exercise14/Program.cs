using Exercise14.Models;

Product product1 = new("Iphone 15", 4500);
Product product2 = new("Kumara Keyboard", 200);
Product product3 = new("Millennium Falcon Lego", 800);

var products = new List<Product>{product1, product2, product3};

var priceAverage = products.Select(p => p.Price).Average();

Console.WriteLine(priceAverage);