﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Finance;

namespace Whimsy_WebAPI.Models.DataModels.Finance
{
    /// <summary>
    /// Represents a financial transaction, which could be either a payment, a refund, a seller deposit or aseller payout.
    /// </summary>
    [Table("Transactions")]
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the unique identifier for the transaction.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated order for this transaction.
        /// This is a foreign key linking to the <see cref="Order"/> entity.
        /// </summary>
        [Required]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or sets the associated <see cref="Order"/> for this transaction.
        /// </summary>
        [ForeignKey(nameof(OrderId))]
        public Order? Order { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date and time when the transaction was made.
        /// </summary>
        [Required]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Gets or sets the amount of money involved in the transaction.
        /// Stored as a decimal with 18 digits of precision and 2 decimal places.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the type of transaction, either a payment or a refund.
        /// </summary>
        [Required]
        public TransactionType Type { get; set; }

        /// <summary>
        /// Gets or sets the payment details if the transaction is of type <see cref="TransactionType.Payment"/>.
        /// This property is nullable as it may not apply to refund, seller deposit or seller payout transactions.
        /// </summary>
        public virtual Payment? Payment { get; set; }

        /// <summary>
        /// Gets or sets the refund details if the transaction is of type <see cref="TransactionType.Refund"/>.
        /// This property is nullable as it may not apply to payment,seller deposit or seller payout transactions.
        /// </summary>
        public virtual Refund? Refund { get; set; }

        /// <summary>
        /// Gets or sets the payment details if the transaction is of type <see cref="TransactionType.SellerDeposit"/>.
        /// This property is nullable as it may not apply to refund, payment or payout schedule transactions.
        /// </summary>
        public virtual SellerDeposit? SellerDeposit { get; set; }

        /// <summary>
        /// Gets or sets the payment details if the transaction is of type <see cref="TransactionType.SellerPayout"/>.
        /// This property is nullable as it may not apply to refund, payment or seller deposit transactions.
        /// </summary>
        public virtual PayoutSchedule? PayoutSchedule { get; set; }

        /// <summary>
        /// Version of the entity for optimistic concurrency control.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
