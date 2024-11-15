﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Whimsy_WebAPI.Models.DataModels.Finance
{
    /// <summary>
    /// Represents a payment method that can be used for transactions.
    /// </summary>
    [Table("PaymentMethods")]
    public class PaymentMethod
    {
        /// <summary>
        /// Gets or sets the unique identifier for the payment method.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the payment method.
        /// This property is initialized to an empty string to avoid null values.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the payment method.
        /// This property is nullable to accommodate cases where no description is provided.
        /// </summary>
        [MaxLength(255)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the collection of payments associated with this shipping method.
        /// </summary>
        public virtual ICollection<Payment> Payments { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of customer payment methods associated with this payment method.
        /// </summary>
        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethods { get; set; } = [];
    }
}
