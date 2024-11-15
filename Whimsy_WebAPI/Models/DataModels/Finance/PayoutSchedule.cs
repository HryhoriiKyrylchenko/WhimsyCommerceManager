using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Enums.Finance;

namespace Whimsy_WebAPI.Models.DataModels.Finance
{
    /// <summary>
    /// Represents a payout schedule entity for a seller.
    /// </summary>
    [Table("PayoutSchedules")]
    public class PayoutSchedule
    {
        /// <summary>
        /// Gets or sets the unique identifier for the payout schedule entry.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the seller associated with the payout schedule.
        /// </summary>
        [Required]
        public string SellerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the associated <see cref="Seller"/> entity for the payout schedule.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the associated transaction for the payout.
        /// This is a foreign key linking to the <see cref="Transaction"/> entity.
        /// </summary>
        public int? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the associated <see cref="Transaction"/> for this payout.
        /// </summary>
        [ForeignKey(nameof(TransactionId))]
        public virtual Transaction? Transaction { get; set; }

        /// <summary>
        /// Gets or sets the scheduled date of the payout.
        /// </summary>
        [Required]
        public DateTime PayoutDate { get; set; }

        /// <summary>
        /// Gets or sets the amount to be paid out to the seller.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PayoutAmount { get; set; }

        /// <summary>
        /// Gets or sets the status of the payout (e.g., Pending, Completed, Failed).
        /// </summary>
        [Required]
        public PayoutStatus Status { get; set; }

        /// <summary>
        /// Gets or sets an optional description of the payout.
        /// </summary>
        [MaxLength(1000)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the row version for optimistic concurrency control.
        /// Used to detect conflicting updates.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
