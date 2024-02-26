using System;

namespace LinqProject;

class Program
{
    public static void Main(string[] args)
    {

        List<Category> categories = new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Bilgisayar"},
            new Category{CategoryId=2, CategoryName="Telefon"}
        };

        List<Product> products = new List<Product>
        {
            new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitInStock = 5 },
            new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 8000, UnitInStock = 3 },
            new Product{ProductId=3, CategoryId=1, ProductName="Huawei Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 6000, UnitInStock = 2 },
            new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitInStock = 15 },
            new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitInStock = 0 }
        };

        /*
        Console.WriteLine("---------algorithm---------");
        
        */

        Console.WriteLine("-------linq-------");


        /*
        foreach (var item in result)
        {
            Console.WriteLine(item.ProductName);
        }
        */

        var items = GetProducts(products);
        foreach (var item in items)
        {
            Console.WriteLine(item.ProductName);
        }

    }

    static List<Product> GetProducts(List<Product> products)
    {
        /*
        List<Product> filteredProducts = new List<Product>();

        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitInStock > 3)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;
        */

        return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();




    }
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }


}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }


}