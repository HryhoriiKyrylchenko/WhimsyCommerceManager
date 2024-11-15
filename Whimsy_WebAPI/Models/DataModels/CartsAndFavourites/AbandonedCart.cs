﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Whimsy_WebAPI.Models.DataModels.CartsAndFavourites
{
    /// <summary>
    /// Represents a shopping cart that has been abandoned by a user without completing a purchase.
    /// Tracks the cart's status and reminder notifications sent to the user.
    /// </summary>
    [Table("AbandonedCarts")]
    public class AbandonedCart
    {
        /// <summary>
        /// Gets or sets the unique identifier for the abandoned cart record.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated shopping cart that was abandoned.
        /// </summary>
        [Required]
        public int ShoppingCartId { get; set; }

        /// <summary>
        /// Gets or sets the associated shopping cart.
        /// </summary>
        [ForeignKey(nameof(ShoppingCartId))]
        public virtual ShoppingCart ShoppingCart { get; set; } = null!;

        /// <summary>
        /// Gets or sets if the shoping cart is abandoned or not.
        /// </summary>
        [Required]
        public bool IsAbandoned { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when the cart was abandoned.
        /// </summary>
        public DateTime? AbandonedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when a reminder was sent to the user about the abandoned cart.
        /// Nullable, as a reminder may not have been sent yet.
        /// </summary>
        public DateTime? ReminderSentAt { get; set; }

        /// <summary>
        /// Gets or sets the count of reminders sent to the user regarding the abandoned cart.
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Reminder count must be a positive number or zero.")]
        public int ReminderCount { get; set; }
    }
}
