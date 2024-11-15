using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products;

namespace Whimsy_WebAPI.Models.DataModels.Discounts
{
    /// <summary>
    /// Represents a many-to-many relationship between product variants and discounts.
    /// This class maps to the "ProductVariantDiscounts" table in the database.
    /// </summary>
    [Table("ProductVariantsDiscounts")]
    public class ProductVariantDiscount
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// This property is required and maps to the ProductVariantId column in the database.
        /// </summary>
        [Required]
        public int ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the product associated with the discount.
        /// This navigation property provides access to the related ProductVariant entity.
        /// </summary>
        [ForeignKey(nameof(ProductVariantId))]
        public virtual ProductVariant ProductVariant { get; set; } = null!;

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
