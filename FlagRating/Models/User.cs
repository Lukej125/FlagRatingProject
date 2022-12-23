#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FlagRating.Models;
public class User
{
    [Key]

    public int UserId { get; set; }
    [Required(ErrorMessage = "First Name is required")]
    [MinLength(2, ErrorMessage = "Your first Name must contain at least 2 characters")]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    // [UniqueEmail]
    public string Email { get; set; }
    [Required]
    [MinLength(8, ErrorMessage = "Your password must contain at least 8 characters")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    [NotMapped]
    [DataType(DataType.Password)]
    [Compare("Password")]
    [Display(Name = "Confirm Password")]
    public string Confirm { get; set; }
    public List<Flag> RatedFlag { get; set; } = new List<Flag>();
    // public List<Rating> Ratings { get; set; } = new List<Rating>();

}

// public class UniqueEmailAttribute : ValidationAttribute
// {
//   protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)

//   {
//     if (value == null)
//     {
//       return new ValidationResult("Email is required test");
//     }
//     MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
//     if (_context.Users.Any(e => e.Email == value.ToString()))
//     {
//       return new ValidationResult("This email is already in use");
//     }
//     else
//     {
//       return ValidationResult.Success;
//     }
//   }
// }