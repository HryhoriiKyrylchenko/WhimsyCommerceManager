using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.CartsAndFavourites
{
    /// <summary>
    /// Represents a seller that a customer has marked as a favorite.
    /// </summary>
    [Table("SellerFavorites")]
    public class SellerFavorite
    {
        /// <summary>
        /// Gets or sets the unique identifier for the favorite entry.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the customer who marked the seller as a favorite.
        /// </summary>
        [Required]
        public string CustomerId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the customer who has marked the seller as a favorite.
        /// </summary>
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier of the seller that has been marked as a favorite.
        /// </summary>
        [Required]
        public string SellerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the seller that has been marked as a favorite.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date and time when the seller was added to the favorites.
        /// </summary>
        [Required]
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    }
}
