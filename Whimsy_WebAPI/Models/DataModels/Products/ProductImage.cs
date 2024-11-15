﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Whimsy_WebAPI.Models.DataModels.Products
{
    /// <summary>
    /// Represents a product image entity.
    /// </summary>
    [Table("ProductImages")]
    public class ProductImage
    {
        /// <summary>
        /// Gets or sets the product image ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the product ID associated with the image.
        /// </summary>
        [Required]
        public int ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the product variant associated with the image.
        /// </summary>
        [ForeignKey(nameof(ProductVariantId))]
        public virtual ProductVariant ProductVariant { get; set; } = null!;

        /// <summary>
        /// Gets or sets the URL of the image.
        /// </summary>
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether this item is marked as the main item.
        /// This property is initialized to <c>false</c> by default.
        /// </summary>
        [Required]
        public bool IsMain { get; set; } = false;
    }
}
