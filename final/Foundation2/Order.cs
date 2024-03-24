namespace Foundation2;
using System;

public class Order
{
    // variables for order
    private List<Product> products;
    private Customer customer;
    private double shippingCost = 0;

    // constructor, if not in USA shipping is 35, if in USA shipping is 5
    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
        if (!customer.IsInUSA())
        {
            shippingCost = 35.0;
        }
        else
        {
            shippingCost = 5.0;
        }
    }

    // add product to list of products
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // total price of products
    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.ComputeProductCost();
        }

        return totalPrice + shippingCost;
    }

    // packing label display
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    // shipping label display
    public string GetShippingLabel()
    {
        return customer.GetName() + "\n" + customer.GetAddress().GetFormattedAddress();
    }
}