using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.CookiePolicy
{
    /// <summary>
    /// Represents the cookie consent given by a user for a specific cookie policy.
    /// </summary>
    [Table("CookieConsents")]
    public class CookieConsent
    {
        /// <summary>
        /// Gets or sets the unique identifier for the cookie consent record.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who gave the consent.
        /// </summary>
        [Required]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the associated user entity.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets a value indicating whether the user has given consent for essential cookies.
        /// Essential cookies are required for the basic functionality of the website.
        /// </summary>
        [Required]
        public bool IsEssentialConsentGiven { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has given consent for optional cookies.
        /// Optional cookies are used for analytics and other non-essential features.
        /// </summary>
        [Required]
        public bool IsOptionalConsentGiven { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the consent was given.
        /// </summary>
        [Required]
        public DateTime ConsentGivenAt { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated cookie policy.
        /// </summary>
        [Required]
        public int CookiePolicyId { get; set; }

        /// <summary>
        /// Gets or sets the associated cookie policy that the user consented to.
        /// </summary>
        [ForeignKey(nameof(CookiePolicyId))]
        public virtual CookiePolicy CookiePolicy { get; set; } = null!;

        /// <summary>
        /// Version of the entity for optimistic concurrency control (optional).
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
