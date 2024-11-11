using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Whimsy_WebAPI.Models.DataModels.Products;
using Whimsy_WebAPI.Models.DataModels.CartsAndFavourites;
using Whimsy_WebAPI.Models.DataModels.Discounts;
using Whimsy_WebAPI.Models.DataModels.Finance;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement
{
    /// <summary>
    /// Represents a seller entity who cat place his items for sale in the marketplace.
    /// </summary>
    [Table("Sellers")]
    public class Seller
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        [Key]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user associated with this entity.
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the shop.
        /// </summary>
        public string ShopName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the shop.
        /// </summary>
        public string ShopDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date when the shop joined the platform.
        /// </summary>
        public DateTime JoinDate { get; set; }

        /// <summary>
        /// Gets or sets the rating of the shop.
        /// </summary>
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets or sets the user's tax identification number (e.g. TIN).
        /// </summary>
        [MaxLength(15)]
        public string? TaxIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or sets user's legal details.
        /// </summary>
        public string? LegalDetails { get; set; }

        /// <summary>
        /// Gets or sets the contact information for the shop.
        /// </summary>
        public string ContactInfo { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the seller accout balance associated with this seller.
        /// </summary>
        public virtual SellerAccountBalance SellerAccountBalance { get; set; } = new();

        /// <summary>
        /// Gets or sets the collection of Product vriants associated with this seller.
        /// </summary>
        public virtual ICollection<ProductVariant> ProductVariants { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of seller favorites associated with the seller.
        /// </summary>
        public virtual ICollection<SellerFavorite> SellerFavorites { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of products discounts associated with the seller.
        /// </summary>
        public virtual ICollection<SellerDiscount> SellersDiscounts { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of seller deposits associated with the seller.
        /// </summary>
        public virtual ICollection<SellerDeposit> SellerDeposits { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of PayoutSchedules associated with the seller.
        /// </summary>
        public virtual ICollection<PayoutSchedule> PayoutSchedules { get; set; } = [];
    }
}
