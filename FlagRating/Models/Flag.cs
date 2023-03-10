#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FlagRating.Models;

public class Flag
{
    [Key]
    public int FlagId { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]

    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //nav things
    public User? Rater { get; set; }

    public List<Rating> Likes { get; set; } = new List<Rating>();




}