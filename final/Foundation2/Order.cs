using System;
using System.Collections.Generic;

public class Order
{
   
    private string customerName;
    private string street;
    private string city;
    private string state;
    private string country;

    private List<Product> products = new List<Product>();

    public Order(string customerName, string street, string city, string state, string country)
    {
        this.customerName = customerName;
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    private bool LivesInUSA()
    {
        return country.ToUpper() == "USA";
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        // shipping
        if (LivesInUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in products)
        {
            label += $"{p.GetName()} (ID: {p.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customerName}\n{street}\n{city}, {state}\n{country}";
    }
}
