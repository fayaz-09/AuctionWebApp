using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Model relating to each individual item listing.
namespace AuctionWebApp.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image {  get; set; }
        public bool IsSold { get; set; } = false;

        //The IdentityUserID is a foreign key which connects each listing to a user. If the user no longer exists the listings belonging to them will be removed.
        [Required]
        public string IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        //? operator allows the value to also be null
        public List<Bid>? Bids { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
