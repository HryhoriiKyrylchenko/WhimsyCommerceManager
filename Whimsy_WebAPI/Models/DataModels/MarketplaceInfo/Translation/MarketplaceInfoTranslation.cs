using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation
{
    /// <summary>
    /// Represents a translated version of a marketplace info in a specific language.
    /// </summary>
    [Table("MarketplaceInfoTranslations")]
    public class MarketplaceInfoTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated marketplace info.
        /// </summary>
        [Required]
        public int MarketplaceInfoId { get; set; }

        /// <summary>
        /// Gets or sets the associated marketplace info.
        /// This navigation property links to the <see cref="MarketplaceInfo"/>.
        /// </summary>
        [ForeignKey(nameof(MarketplaceInfoId))]
        public virtual MarketplaceInfo MarketplaceInfo { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the marketplace.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string MarketplaceName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the marketplace.
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the contact email address for the marketplace.
        /// </summary>
        [Required]
        [MaxLength(500)]
        public string ContactEmail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the contact phone number for the marketplace (optional).
        /// </summary>
        [MaxLength(500)]
        public string? ContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the contact address for the marketplace (optional).
        /// </summary>
        [MaxLength(500)]
        public string? ContactAddress { get; set; }

        /// <summary>
        /// Gets or sets additional information about the marketplace (optional).
        /// </summary>
        public string? AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or sets the language code for this translation.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the version of the translation.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date and time when the translation was last updated.
        /// </summary>
        [Required]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who last modified the translation.
        /// </summary>
        [Required]
        public string LastModifiedByUserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user who last modified the translation.
        /// This navigation property links to the <see cref="ApplicationUser"/> representing the user.
        /// </summary>
        [ForeignKey(nameof(LastModifiedByUserId))]
        public virtual ApplicationUser LastModifiedBy { get; set; } = null!;
    }
}
