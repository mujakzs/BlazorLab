namespace BlazorLab.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
        public bool isActive { get; set; }

        public IEnumerable<Product_Prop> Props { get; set; }
    }
}
