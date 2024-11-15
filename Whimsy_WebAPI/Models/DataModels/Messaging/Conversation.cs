using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.Messaging
{
    /// <summary>
    /// Represents a conversation between a buyer and a seller.
    /// </summary>
    [Table("Conversations")]
    public class Conversation
    {
        /// <summary>
        /// Gets or sets the unique identifier for the conversation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the buyer involved in the conversation.
        /// </summary>
        [Required]
        public string BuyerId { get; set; } = null!;

        /// <summary>
        /// Navigation property for the buyer (customer) involved in the conversation.
        /// </summary>
        [ForeignKey(nameof(BuyerId))]
        public virtual Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the ID of the seller involved in the conversation.
        /// </summary>
        [Required]
        public string SellerId { get; set; } = null!;

        /// <summary>
        /// Navigation property for the seller involved in the conversation.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets a value indicating whether the conversation is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when the conversation was created. Defaults to the current UTC time.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Navigation property for the collection of messages within the conversation.
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
