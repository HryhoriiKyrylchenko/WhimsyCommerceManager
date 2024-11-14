using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Utilities;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo
{
    /// <summary>
    /// Represents a partnership agreement in the system.
    /// </summary>
    [Table("PartnershipAgreements")]
    public class PartnershipAgreement
    {
        /// <summary>
        /// Gets or sets the unique identifier for the partnership agreement.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the agreement was last updated.
        /// </summary>
        [Required]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who last modified the agreement.
        /// </summary>
        [Required]
        public string LastModifiedByUserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user who last modified the agreement.
        /// </summary>
        [ForeignKey(nameof(LastModifiedByUserId))]
        public virtual ApplicationUser LastModifiedBy { get; set; } = null!;

        /// <summary>
        /// Gets or sets a value indicating whether the partnership agreement is currently active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the version of the partnership agreement.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of consents associated with this partnership agreement.
        /// </summary>
        public virtual ICollection<PartnershipAgreementConsent> PartnershipAgreementConsents { get; set; } = [];

        /// <summary>
        /// Gets or sets the translation for the marketplace agreement.
        /// </summary>
        public virtual ICollection<PartnershipAgreementTranslation> Translations { get; set; } = [];
    }
}
