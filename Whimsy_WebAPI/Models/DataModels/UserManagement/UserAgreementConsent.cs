using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement
{
    /// <summary>
    /// Represents the consent given by a user to a specific user agreement.
    /// This entity stores information about when and from where the user accepted the agreement.
    /// </summary>
    [Table("UserAgreementConsents")]
    public class UserAgreementConsent
    {
        /// <summary>
        /// Gets or sets the unique identifier for the consent record.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the user who gave the consent.
        /// </summary>
        [Required]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user who gave the consent.
        /// This navigation property links to the <see cref="ApplicationUser"/> representing the user.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier for the agreement that was accepted by the user.
        /// </summary>
        [Required]
        public int AgreementId { get; set; }

        /// <summary>
        /// Gets or sets the user agreement that was accepted.
        /// This navigation property links to the <see cref="UserAgreement"/> representing the agreement.
        /// </summary>
        [ForeignKey(nameof(AgreementId))]
        public virtual UserAgreement Agreement { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date and time when the user gave consent to the agreement.
        /// </summary>
        [Required]
        public DateTime ConsentGivenAt { get; set; }

        /// <summary>
        /// Gets or sets whether the user accepted the agreement or not.
        /// </summary>
        [Required]
        public bool IsAccepted { get; set; }

        /// <summary>
        /// Gets or sets the IP address from which the user accepted the agreement.
        /// This property can be null if the IP address is not tracked.
        /// </summary>
        public string? AcceptedFromIp { get; set; }
    }
}
