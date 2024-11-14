using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation
{
    /// <summary>
    /// Represents a translated version of a partnership agreements in a specific language.
    /// </summary>
    [Table("PartnershipAgreementTranslations")]
    public class PartnershipAgreementTranslation
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
        public int PartnershipAgreementId { get; set; }

        /// <summary>
        /// Gets or sets the associated marketplace returns.
        /// This navigation property links to the <see cref="PartnershipAgreement"/>.
        /// </summary>
        [ForeignKey(nameof(PartnershipAgreementId))]
        public virtual PartnershipAgreement PartnershipAgreement { get; set; } = null!;

        /// <summary>
        /// Gets or sets the text of the partnership agreement.
        /// </summary>
        [Required]
        public string AgreementText { get; set; } = string.Empty;

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
