namespace GrossApp.WebAPI.Models
{
    public class Login
    {
        public string Username { get; set; } // Primary Key
        public Guid UserId { get; set; } // Foreign Key to Admin
        public string Password { get; set; }

        // Navigation property
        public Admin Admin { get; set; }
    }
}
