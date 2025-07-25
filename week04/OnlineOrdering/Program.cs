using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order - USA
        Address address1 = new Address("Green lodge, amassoma", "Bayelsa state", "NG", "Nigeria");
        Customer customer1 = new Customer("Tega Chisom churchill", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("USB Cable", "U001", 5.99, 2));
        order1.AddProduct(new Product("Wireless Mouse", "W123", 15.50, 1));
        order1.AddProduct(new Product("Notebook", "N456", 3.25, 5));

        DisplayOrder(order1);

        // Second Order - International
        Address address2 = new Address("456 Banana Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Boma Ephraim", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Bluetooth Speaker", "B789", 25.00, 1));
        order2.AddProduct(new Product("Headphones", "H101", 45.75, 1));

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
        Console.WriteLine(new string('-', 40));
    }
}
