using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.Finance
{
    /// <summary>
    /// Represents an account balance for a seller.
    /// </summary>
    [Table("SellerAccountBalances")]
    public class SellerAccountBalance
    {
        /// <summary>
        /// Gets or sets the unique identifier for the seller's account balance entry.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the seller associated with the account balance.
        /// </summary>
        [Required]
        public int SellerId { get; set; }

        /// <summary>
        /// Gets or sets the associated <see cref="Seller"/> entity for the account balance.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the available balance in the seller's account.
        /// This amount is available for payout or other transactions.
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal AvailableBalance { get; set; }

        /// <summary>
        /// Gets or sets the pending balance in the seller's account.
        /// This amount is not available for payout yet but is pending confirmation.
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal PendingBalance { get; set; }

        /// <summary>
        /// Gets or sets the date of the last payout for this seller.
        /// </summary>
        public DateTime LastPayoutDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the account balance was last updated.
        /// Defaults to the current UTC date and time.
        /// </summary>
        [Required]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the row version for optimistic concurrency control.
        /// Used to detect conflicting updates.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
