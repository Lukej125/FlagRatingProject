#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FlagRating.Models;

public class Rating
{
    [Key]
    public int RatingId { get; set; }
    public int FlagId { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public Flag? Flag { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}