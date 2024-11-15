﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Purchase;
using Whimsy_WebAPI.Models.DataModels.Products;

namespace Whimsy_WebAPI.Models.DataModels.Purchase
{
    /// <summary>
    /// Represents an order item entity.
    /// </summary>
    [Table("OrderItems")]
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets the order item ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the order ID associated with the order item.
        /// </summary>
        [Required]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the order associated with the order item.
        /// </summary>
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        /// <summary>
        /// Gets or sets the product ID associated with the order item.
        /// </summary>
        [Required]
        public int ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the product variant associated with the order item.
        /// </summary>
        [ForeignKey(nameof(ProductVariantId))]
        public ProductVariant ProductVariant { get; set; } = null!;

        /// <summary>
        /// Gets or sets the quantity of the product in the order item.
        /// </summary>
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive integer.")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the product in the order item.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalUnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the status of the order item.
        /// </summary>
        [Required]
        public OrderItemStatus Status { get; set; } = OrderItemStatus.Pending;

        /// <summary>
        /// Gets or sets the quantity of the order item that was canceled.
        /// </summary>
        public int CanceledQuantity { get; set; } = 0;

        /// <summary>
        /// Version of the entity for optimistic concurrency control.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
