using Whimsy_WebAPI.Models.DataModels.UserManagement;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Whimsy_WebAPI.Models.DataModels.Messaging
{
    /// <summary>
    /// Represents a message in a conversation between two users.
    /// </summary>
    [Table("Messages")]
    public class Message
    {
        /// <summary>
        /// Gets or sets the unique identifier for the message.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the conversation this message belongs to.
        /// </summary>
        [Required]
        public int ConversationId { get; set; }

        /// <summary>
        /// Navigation property for the conversation to which this message belongs.
        /// </summary>
        [ForeignKey(nameof(ConversationId))]
        public virtual Conversation Conversation { get; set; } = null!;

        /// <summary>
        /// Gets or sets the ID of the user who sent the message.
        /// </summary>
        [Required]
        public string SenderId { get; set; } = null!;

        /// <summary>
        /// Navigation property for the user who sent the message.
        /// </summary>
        [ForeignKey(nameof(SenderId))]
        public virtual ApplicationUser Sender { get; set; } = null!;

        /// <summary>
        /// Gets or sets the ID of the user who is the recipient of the message.
        /// </summary>
        [Required]
        public string ReceiverId { get; set; } = null!;

        /// <summary>
        /// Navigation property for the user who received the message.
        /// </summary>
        [ForeignKey(nameof(ReceiverId))]
        public virtual ApplicationUser Receiver { get; set; } = null!;

        /// <summary>
        /// Gets or sets the content of the message, with a maximum length of 2000 characters.
        /// </summary>
        [Required]
        [MaxLength(2000)]
        public string Content { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date and time when the message was sent. Defaults to UTC now.
        /// </summary>
        [Required]
        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets a value indicating whether the message has been read by the receiver.
        /// </summary>
        public bool IsRead { get; set; } = false;
    }
}