using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation;
using Whimsy_WebAPI.Models.DataModels.Messaging;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Utilities;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo
{
    /// <summary>
    /// Represents a user agreement document that users must accept.
    /// </summary>
    [Table("UserAgreements")]
    public class UserAgreement
    {
        /// <summary>
        /// Gets or sets the unique identifier for the agreement.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the agreement was last updated.
        /// </summary>
        [Required]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who last modified the entity.
        /// </summary>
        [Required]
        public string LastModifiedByUserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user who last modified the entity.
        /// This navigation property links to the <see cref="ApplicationUser"/> representing the user.
        /// </summary>
        [ForeignKey(nameof(LastModifiedByUserId))]
        public virtual ApplicationUser LastModifiedBy { get; set; } = null!;

        /// <summary>
        /// Gets or sets the status of the agreement (active or inactive).
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the version of the agreement.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of user agreement consents associated with the user.
        /// </summary>
        public virtual ICollection<UserAgreementConsent> UserAgreementConsents { get; set; } = [];

        /// <summary>
        /// Gets or sets the translation for the marketplace agreement.
        /// </summary>
        public virtual ICollection<UserAgreementTranslation> Translations { get; set; } = [];
    }
}
