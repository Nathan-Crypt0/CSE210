using System;

public class Program
{
    static void Main(string[] args)
    {
        
        Order order1 = new Order(
            "Luke Skywalker",
            "123 Main St",
            "Rexburg",
            "ID",
            "USA"
        );

        order1.AddProduct(new Product("Blue Lightsaber", "JEDI001", 149.99, 1));
        order1.AddProduct(new Product("Training Remote", "JEDI002", 39.99, 2));

        
        Order order2 = new Order(
            "Darth Vader",
            "42 Imperial Way",
            "Coruscant",
            "Sector 3",
            "Galactic Empire"
        );

        order2.AddProduct(new Product("Sith Holocron", "SITH777", 199.99, 1));
        order2.AddProduct(new Product("Cape Polish", "SITH420", 24.50, 3));

        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");
        Console.WriteLine("-----------------------------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}