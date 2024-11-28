using System.ComponentModel.DataAnnotations;

namespace TOR.API.DTOs
{
    public class RegisterDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        public string Firstname { get; set; } = string.Empty;

        public string Middlename { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; } = string.Empty;

        public string Suffix { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact is required")]
        public string Contact { get; set; } = string.Empty;

        public string AccountType { get; set; } = "User";

        public string Status { get; set; } = "Active";

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public int? MunicipalityId { get; set; }

        public int? EstablishmentId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; } = string.Empty;
    }
}