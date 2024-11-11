﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products;

namespace Whimsy_WebAPI.Models.DataModels.Discounts
{
    /// <summary>
    /// Represents a many-to-many relationship between categories and discounts.
    /// This class maps to the "CategoryDiscounts" table in the database.
    /// </summary>
    [Table("CategoryDiscounts")]
    public class CategoryDiscount
    {
        /// <summary>
        /// Gets or sets the unique identifier for the category.
        /// This property is required and maps to the CategoryId column in the database.
        /// </summary>
        [Key, Column(Order = 0)]
        [Required]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category associated with the discount.
        /// This navigation property provides access to the related ProductCategory entity.
        /// </summary>
        [ForeignKey(nameof(CategoryId))]
        public virtual ProductCategory Category { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier for the discount.
        /// This property is required and maps to the DiscountId column in the database.
        /// </summary>
        [Key, Column(Order = 1)]
        [Required]
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the discount associated with the category.
        /// This navigation property provides access to the related Discount entity.
        /// </summary>
        [ForeignKey(nameof(DiscountId))]
        public virtual Discount Discount { get; set; } = null!;
    }
}
