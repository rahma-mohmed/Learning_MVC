namespace Day1.Models
{
    public static class ProductList
    {
        public static List<Product>Products { get; set; }

        static ProductList()
        {
            Products = new List<Product>();
            Products.Add(new Product { Id = 1, Name = "Phone1", price = 1000, Image = "1.jpg" });
            Products.Add(new Product { Id = 2, Name = "Phone2", price = 1500, Image = "2.jpg" });
            Products.Add(new Product { Id = 3, Name = "Phone3", price = 2000, Image = "3.jpg" });

        }
    }
}
