using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA customer
        Address address1 = new Address("123 Tantua", "Amassoma", "Bayelsa state", "Nigeria");
        Customer customer1 = new Customer("Tega Churchill", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K001", 25.99, 2));
        order1.AddProduct(new Product("Mouse", "M002", 12.50, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        // Order 2 - International customer
        Address address2 = new Address("456 Maple Lane", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Boma Ephraim", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "L003", 799.99, 1));
        order2.AddProduct(new Product("Headphones", "H004", 59.99, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
