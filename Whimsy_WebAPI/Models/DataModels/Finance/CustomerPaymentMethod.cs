﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.Finance
{
    /// <summary>
    /// Represents a payment method used by a customer.
    /// </summary>
    [Table("CustomerPaymentMethods")]
    public class CustomerPaymentMethod
    {
        /// <summary>
        /// Gets or sets the customer ID associated with the payment method.
        /// </summary>
        [Required]
        public string CustomerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the customer associated with the payment method.
        /// </summary>
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the payment method ID associated with the payment method.
        /// </summary>
        [Required]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or sets the payment method details.
        /// </summary>
        [ForeignKey(nameof(PaymentMethodId))]
        public virtual PaymentMethod PaymentMethod { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of dates when this payment method was used.
        /// </summary>
        [Required]
        public ICollection<DateTime> UsedDates { get; set; } = [];

        /// <summary>
        /// Gets or sets a flag indicating if this is the current payment method.
        /// </summary>
        [Required]
        public bool IsCurrent { get; set; }
    }
}
