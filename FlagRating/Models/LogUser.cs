#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FlagRating.Models;
public class LogUser
{
    [Required(ErrorMessage = "Put in your email goof ball")]
    [EmailAddress]

    public string LEmail { get; set; }
    [Required(ErrorMessage = "Put in your password goober")]
    [DataType(DataType.Password)]
    public string LPassword { get; set; }

}