using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo
{
    /// <summary>
    /// Represents a social media link associated with the marketplace.
    /// </summary>
    public class SocialMediaLink
    {
        /// <summary>
        /// Gets or sets the unique identifier for the social media link.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the social media platform (e.g., "Facebook", "Twitter").
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Platform { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the social media profile.
        /// </summary>
        [Required]
        [MaxLength(500)]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the marketplace information this social media link belongs to.
        /// </summary>
        [Required]
        public int MarketplaceInfoId { get; set; }

        /// <summary>
        /// Gets or sets the marketplace information this social media link belongs to.
        /// </summary>
        [ForeignKey(nameof(MarketplaceInfoId))]
        public virtual MarketplaceInfo MarketplaceInfo { get; set; } = null!;
    }
}
