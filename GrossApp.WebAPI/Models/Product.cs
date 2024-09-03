namespace GrossApp.WebAPI.Models
{
    public class Product
    {
        public Guid ProductId { get; set; } = Guid.NewGuid(); // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // Foreign Key
        public Guid AdminId { get; set; }
        public Admin Admin { get; set; }
    }
}
