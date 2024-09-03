namespace GrossApp.WebAPI.Models
{
    public class Admin
    {
        public Guid AdminId { get; set; } = Guid.NewGuid(); // Primary Key
        public string Name { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; }
        public Login Login { get; set; }
    }
}
