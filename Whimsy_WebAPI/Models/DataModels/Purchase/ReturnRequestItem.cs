﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products;

namespace Whimsy_WebAPI.Models.DataModels.Purchase
{
    /// <summary>
    /// Represents an item in a return request.
    /// </summary>
    [Table("ReturnRequestItems")]
    public class ReturnRequestItem
    {
        /// <summary>
        /// Gets or sets the return request item ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the return request ID associated with this item.
        /// </summary>
        [Required]
        public int ReturnRequestId { get; set; }

        /// <summary>
        /// Gets or sets the return request associated with this item.
        /// </summary>
        [ForeignKey(nameof(ReturnRequestId))]
        public virtual ReturnRequest ReturnRequest { get; set; } = null!;

        /// <summary>
        /// Gets or sets the product variant ID being returned.
        /// </summary>
        [Required]
        public int ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the product being returned.
        /// </summary>
        [ForeignKey(nameof(ProductVariantId))]
        public virtual ProductVariant ProductVariant { get; set; } = null!;

        /// <summary>
        /// Gets or sets the quantity of the product being returned.
        /// </summary>
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive integer.")]
        public int Quantity { get; set; }
    }
}
