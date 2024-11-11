using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.Discounts
{
    /// <summary>
    /// Represents a many-to-many relationship between sellers and discounts.
    /// This class maps to the "SellersDiscounts" table in the database.
    /// </summary>
    [Table("SellersDiscounts")]
    public class SellerDiscount
    {
        /// <summary>
        /// Gets or sets the unique identifier for the seller.
        /// This property is required and maps to the SellerId column in the database.
        /// </summary>
        [Required]
        public int SellerId { get; set; }

        /// <summary>
        /// Gets or sets the seller associated with the discount.
        /// This navigation property provides access to the related Seller entity.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier for the discount.
        /// This property is required and maps to the DiscountId column in the database.
        /// </summary>
        [Required]
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the discount associated with the product.
        /// This navigation property provides access to the related Discount entity.
        /// </summary>
        [ForeignKey(nameof(DiscountId))]
        public virtual Discount Discount { get; set; } = null!;
    }
}
