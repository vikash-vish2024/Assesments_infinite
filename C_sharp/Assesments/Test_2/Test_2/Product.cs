using System;

class Product
{
    public int Product_Id { get; set; }
    public string Product_Name { get; set; }
    public double Product_Price { get; set; }
}

class ProductSorter
{
    public static void Main()
    {
        Product[] products = new Product[10];

        Console.WriteLine("-----Getting Product Details-----");

        Console.WriteLine("Enter details of products -> ");
        for (int i = 0; i < products.Length; i++)
        {
            Console.Write($"Product {i + 1}  ID -> ");
            int product_Id = int.Parse(Console.ReadLine());
            Console.Write($"Product {i + 1}  Name -> ");
            string product_Name = Console.ReadLine();
            Console.Write($"Product {i + 1}  Price -> ");
            double product_Price = double.Parse(Console.ReadLine());

            products[i] = new Product { Product_Id = product_Id, Product_Name = product_Name, Product_Price = product_Price };
        }

        // Sorting 
        Array.Sort(products, (a, b) => a.Product_Price.CompareTo(b.Product_Price));

     
        Console.WriteLine("Sorted Products based on Price:");

        foreach (Product product in products)
        {
            Console.WriteLine($"Product ID: {product.Product_Id}, Name: {product.Product_Name}, Price: {product.Product_Price}");
        }
    }
}