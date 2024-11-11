using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Enums.Finance;

namespace Whimsy_WebAPI.Models.DataModels.Finance
{
    /// <summary>
    /// Represents a seller deposit associated with a transaction.
    /// </summary>
    [Table("SellerDeposits")]
    public class SellerDeposit
    {
        /// <summary>
        /// Gets or sets the unique identifier for the seller deposit entry.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the seller making the deposit.
        /// </summary>
        [Required]
        public int SellerId { get; set; }

        /// <summary>
        /// Gets or sets the associated <see cref="Seller"/> entity.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the associated transaction.
        /// This is a foreign key linking to the <see cref="Transaction"/> entity.
        /// </summary>
        [Required]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the associated <see cref="Transaction"/> for this deposit.
        /// </summary>
        [ForeignKey(nameof(TransactionId))]
        public virtual Transaction? Transaction { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date when the deposit was made.
        /// Defaults to the current UTC date and time.
        /// </summary>
        [Required]
        public DateTime DepositDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the amount of the deposit.
        /// The value is stored as a decimal with two decimal places.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the status of the deposit (e.g., Pending, Completed, Failed).
        /// </summary>
        [Required]
        public DepositStatus Status { get; set; }

        /// <summary>
        /// Gets or sets an optional description of the deposit transaction.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the row version for optimistic concurrency control.
        /// Used to detect conflicting updates.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
