using System.Collections.Generic;

namespace Day1.Models
{
    public static class ProductList
    {
        public static List<Product> Products { get; set; }
        static ProductList()
        {
            Products = new List<Product>();
            Products.Add(new Product() { ID = 1, Name = "Phone1", Price = 1000, Image = "1.jpg" });
            Products.Add(new Product() { ID = 2, Name = "Phone2", Price = 1500, Image = "2.jpg" });
            Products.Add(new Product() { ID = 3, Name = "Phone3", Price = 2000, Image = "3.jpg" });
        }
    }
}

