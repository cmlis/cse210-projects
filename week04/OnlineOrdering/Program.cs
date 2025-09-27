using System;

class Program
{
    static void Main(string[] args)
    {
          // Address
        Address addr1 = new Address("123 Main St", "Av. Alberth", "SP", "Brazil");
        Address addr2 = new Address("456 Maple Rd", "Salt Lake", "UT", "USA");

        //Customers
        Customer cust1 = new Customer("Camila Santana", addr1);
        Customer cust2 = new Customer("Brother Reading", addr2);

        // Products
        Product prod1 = new Product(1, "Iphone", 999.99, 1);
        Product prod2 = new Product(2, "Phone Case", 15.50, 2);

        Product prod3 = new Product(3, "Keyboard", 10.99, 2);
        Product prod4 = new Product(4, "C# Book", 20.99, 2);
        Product prod5 = new Product(5, "Pencil", 1.50, 5);

        //Orders
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);


        //Console
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}