namespace Sprint_13_Dy_Sa_Bo.Models
{
    public class Product
    {
        public string Name {  get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
