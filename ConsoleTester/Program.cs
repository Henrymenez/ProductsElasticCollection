using System;
using ElasticCollection.Data;

namespace ConsoleTester
{
    internal class Program
    {
        public static List<Product> products = new List<Product>();
       public static void displayAll()
        {
            foreach (Product product in products )
            {
                Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name},Quantity: {product.Quantity}," +
                    $"Pric: ${product.Price},Category: {product.Category},OrderCount: {product.OrderCount}");
            }
        }
        static void Main(string[] args)
        {

            products.Add(new Product(1, "Dell xps", 30, 1500, "PCs", 1000));
            products.Add(new Product(2, "Ergonomic Chair", 400, 200, "Chairs", 4000));
            products.Add(new Product(3, "Table", 500, 250, "Tables", 3000));

            Console.WriteLine("Weclome to our store \n 1) To display all the products \n" +
                " 2) To select Order Yourself ");
            string choiceOne = Console.ReadLine();

            switch(choiceOne)
            {
                case "1":
                    displayAll();
                    break;
            }


        }
    }
}