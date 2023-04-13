namespace Super_Movie_Store.Models.ViewModel
{
    public class LoginSignupViewModel
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }

        public string? Mobile { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsRemember { get; set; }

    }
}
