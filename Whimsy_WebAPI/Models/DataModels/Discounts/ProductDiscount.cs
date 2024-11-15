﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products;

namespace Whimsy_WebAPI.Models.DataModels.Discounts
{
    /// <summary>
    /// Represents a many-to-many relationship between products and discounts.
    /// This class maps to the "ProductDiscounts" table in the database.
    /// </summary>
    [Table("ProductsDiscounts")]
    public class ProductDiscount
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// This property is required and maps to the ProductId column in the database.
        /// </summary>
        [Key, Column(Order = 0)]
        [Required]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product associated with the discount.
        /// This navigation property provides access to the related Product entity.
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier for the discount.
        /// This property is required and maps to the DiscountId column in the database.
        /// </summary>
        [Key, Column(Order = 1)]
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
