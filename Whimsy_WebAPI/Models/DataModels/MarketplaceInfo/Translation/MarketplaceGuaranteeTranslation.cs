using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Enums.Translation;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation
{
    /// <summary>
    /// Represents a translated version of a marketplace guarantee in a specific language.
    /// </summary>
    [Table("MarketplaceGuaranteeTranslations")]
    public class MarketplaceGuaranteeTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated marketplace guarantee.
        /// </summary>
        [Required]
        public int MarketplaceGuaranteeId { get; set; }

        /// <summary>
        /// Gets or sets the associated marketplace guarantee.
        /// This navigation property links to the <see cref="MarketplaceGuarantee"/>.
        /// </summary>
        [ForeignKey(nameof(MarketplaceGuaranteeId))]
        public virtual MarketplaceGuarantee MarketplaceGuarantee { get; set; } = null!;

        /// <summary>
        /// Gets or sets the translated title of the guarantee.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string GuaranteeTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the translated details of the guarantee.
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string GuaranteeDetails { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any additional information about the guarantee.
        /// </summary>
        [MaxLength(1000)]
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
