namespace Foundation2;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating products
        Product product1 = new Product("Product 1", "P001", 10.5, 2);
        Product product2 = new Product("Product 2", "P002", 7.5, 3);
        Product product3 = new Product("Product 3", "P003", 15.75, 1);

        // Creating customers
        Address customerAddress1 = new Address("123 Main St", "San Antonio", "TX", "USA");
        Customer customer1 = new Customer("Emilie Mickelsen", customerAddress1);

        Address customerAddress2 = new Address("4563 Oak St", "Victoria", "BC", "Canada");
        Customer customer2 = new Customer("Bekah Smith", customerAddress2);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Displaying packing labels, shipping labels, and total prices
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + order2.GetTotalPrice());
    }
}