using System;

public class Product
{
    private string name;
    private string id;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.pricePerUnit = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetId()
    {
        return id;
    }
}
