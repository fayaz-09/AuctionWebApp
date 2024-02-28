using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionWebApp.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public double Price { get; set; }

        //The IdentityUserID is a foreign key which connects each bid to a user. If the user no longer exists the bids belonging to them will be removed.
        [Required]
        public string IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        public int? ListingId { get; set; }
        [ForeignKey("ListingId")]
        public Listing? Listing { get; set; }
    }
}
