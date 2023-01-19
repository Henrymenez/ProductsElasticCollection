using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using ElasticCollection.Data;

namespace ElasticCollection.implementation
{
    public class ElasticCollectionApp
    {

        public static void ShowAll()
        {
            foreach (Product product in ProductDB.products)
            {
                Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name},Quantity: {product.Quantity}," +
                    $"Pric: ${product.Price},Category: {product.Category},OrderCount: {product.OrderCount}");
            }
        }

        public static void DynamicDisplay(string search)
        {
   
            dynamic ProductObject = new ExpandoObject();

            foreach (Product product in ProductDB.products)
            {
                ProductObject.id = product.Id;
                ProductObject.name = product.Name;
                ProductObject.quantity = product.Quantity;
                ProductObject.price = product.Price;
                ProductObject.category = product.Category;
                ProductObject.orderCount = product.OrderCount;


                foreach (var item in (IDictionary<String, Object>)ProductObject)
                {
                    foreach(string word in search.Split(' '))
                    {
                        if(item.Key.ToLower() == word.ToLower())
                        {
                            Console.WriteLine(item.Key + " " + item.Value);
                            
                        }
                       
                    }
                   
                }
                Console.WriteLine("------------------------");

            }

        }
        public enum ProductOptions 
        {
            ID = 1,
            Name = 2,
            Quantity = 3,
            Price = 4,
            Category = 5,
            OrderCount = 6
        }
    }
}
