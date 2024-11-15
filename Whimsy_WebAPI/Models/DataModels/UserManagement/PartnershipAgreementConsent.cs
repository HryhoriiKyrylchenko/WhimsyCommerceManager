using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement
{
    /// <summary>
    /// Represents a record of a user's consent to a partnership agreement.
    /// </summary>
    [Table("PartnershipAgreementConsents")]
    public class PartnershipAgreementConsent
    {
        /// <summary>
        /// Gets or sets the unique identifier for the consent record.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who provided consent.
        /// </summary>
        [Required]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user who provided consent.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the ID of the partnership agreement for which consent is provided.
        /// </summary>
        [Required]
        public int AgreementId { get; set; }

        /// <summary>
        /// Gets or sets the partnership agreement associated with this consent record.
        /// </summary>
        [ForeignKey(nameof(AgreementId))]
        public virtual PartnershipAgreement Agreement { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date and time when consent was given.
        /// </summary>
        [Required]
        public DateTime ConsentGivenAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user accepted the partnership agreement.
        /// </summary>
        [Required]
        public bool IsAccepted { get; set; }

        /// <summary>
        /// Gets or sets the IP address from which consent was given, if available.
        /// </summary>
        public string? AcceptedFromIp { get; set; }
    }
}