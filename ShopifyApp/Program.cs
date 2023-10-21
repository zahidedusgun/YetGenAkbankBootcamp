using ShopifyApp.Context;
using ShopifyApp.Entities;

Console.WriteLine("PostgreSQL Exercise");

ShopifyDbContext _context = new();

#region AddSingle
Product product1 = new Product("Laptop", 2.5m, 999.99m);
_context.Products.Add(product1);

_context.SaveChanges();
#endregion

#region AddMultiple
List<Product> Allproducts = new List<Product> 
{
     new Product("Smartphone", 0.3m, 699.99m),
     new Product("Headphones", 0.1m, 49.99m),
     new Product("Coffee Maker", 4.0m, 149.99m),
     new Product("Television", 12.0m, 799.99m),
     new Product("Tablet", 0.5m, 299.99m),
     new Product("Washing Machine", 25.0m, 599.99m)

};
_context.Products.AddRange(Allproducts);
_context.SaveChanges();
#endregion