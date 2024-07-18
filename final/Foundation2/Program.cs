using System;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress = new Address("123 Main St", "Los Angeles", "California", "USA");

        Customer customer = new Customer("John Doe", customerAddress);

        Product product1 = new Product("bread", "1", 2.50, 3);
        Product product2 = new Product("toy", "2", 15.75, 1);
        Product product3 = new Product("cereal", "3", 6.25, 2);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        Console.WriteLine("Packing Label:\n" + order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order.GetShippingLabel());
        Console.WriteLine("\nTotal Cost of Order: $" + order.GetTotalCost());

        Console.WriteLine();

        Address customerAddress2 = new Address("456 Main Blvd", "Calgary", "Alberta", "canada");

        Customer customer2 = new Customer("Jane Doe", customerAddress2);

        Product product4 = new Product("milk", "1", 3.25, 3);
        Product product5 = new Product("dog food", "2", 25.50, 1);
        Product product6 = new Product("bowl", "3", 10.75, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("\nTotal Cost of Order: $" + order2.GetTotalCost());
    }
}