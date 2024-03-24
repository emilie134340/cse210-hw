namespace Foundation2;
using System;

public class Product
{
    // product variables and getter for name/productId
    private string name;
    private string productId;
    private double pricePerUnit;
    private int quantity;

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }

    // constructor
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity; 
    }

    // compute the cost of each type of product
    public double ComputeProductCost()
    {
        return pricePerUnit * quantity;
    }

}