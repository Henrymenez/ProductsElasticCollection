using System.Collections.Generic;

namespace ElasticCollection.Data
{
    public class ProductDB
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(1, "Dell xps", 30, 1500, "PCs", 1000),
            new Product(2, "Ergonomic Chair", 400, 200, "Chairs", 4000),
            new Product(3, "Table", 500, 250, "Tables", 3000)
        };

    }
}
