﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.CartsAndFavourites
{
    /// <summary>
    /// Represents a shopping cart entity.
    /// </summary>
    [Table("ShoppingCarts")]
    public class ShoppingCart
    {
        /// <summary>
        /// Gets or sets the shopping cart ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID associated with the shopping cart.
        /// </summary>
        [Required]
        public string CustomerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the customer associated with the shopping cart.
        /// </summary>
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date when the cart was created.
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the last updated date of the shopping cart.
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the object of abandoned cart if this shopping cart has been abandoned.
        /// </summary>
        public virtual AbandonedCart? AbandonedCart { get; set; }

        /// <summary>
        /// Gets or sets the collection of items in the shopping cart.
        /// </summary>
        public virtual ICollection<ShoppingCartItem> Items { get; set; } = [];
    }
}
