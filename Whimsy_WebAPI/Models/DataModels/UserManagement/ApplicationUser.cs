using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Enums.UserManagement;
using Whimsy_WebAPI.Models.DataModels.CookiePolicy;
using Whimsy_WebAPI.Models.DataModels.Messaging;
using Whimsy_WebAPI.Models.DataModels.Notifications;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement
{
    /// <summary>
    /// Represents an application user.
    /// </summary>
    [Table("ApplicationUsers")]
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's date of birth.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the user's gender.
        /// </summary>
        [MaxLength(10)]
        public GenderType? Gender { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's profile picture.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the entity was created. 
        /// The default value is set to the current UTC date and time.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date and time when the entity was last updated. 
        /// This value is nullable and can be null if the entity has not been updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the user's preferred language for application localization.
        /// </summary>
        public LanguageCode PreferredLanguage { get; set; }

        /// <summary>
        /// Gets or sets the user's time zone to adjust dates and times according to their local time.
        /// This property is nullable to accommodate users who may not have a time zone set.
        /// </summary>
        public string? TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the seller associated with this entity.
        /// </summary>
        public virtual Seller? Seller { get; set; }

        /// <summary>
        /// Gets or sets the customer associated with this entity.
        /// </summary>
        public virtual Customer? Customer { get; set; }

        /// <summary>
        /// Gets or sets the employee associated with this entity.
        /// </summary>
        public virtual Employee? Employee { get; set; }

        /// <summary>
        /// Gets or sets user addresses.
        /// </summary>
        public virtual ICollection<UserAddress> UserAddresses { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of refresh tokens associated with the user.
        /// </summary>
        /// <remarks>
        /// This collection is typically used to store multiple refresh tokens for the user, 
        /// allowing for the management of issued tokens for security purposes.
        /// </remarks>
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of notifications associated with the user.
        /// </summary>
        public virtual ICollection<Notification> Notifications { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of messages associated with the user.
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of user agreement consents associated with the user.
        /// </summary>
        public virtual ICollection<UserAgreementConsent> UserAgreementConsents { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of partnership agreement consents associated with the user.
        /// </summary>
        public virtual ICollection<PartnershipAgreementConsent> PartnershipAgreementConsents { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of cookie consents associated with the user.
        /// </summary>
        public virtual ICollection<CookieConsent> CookieConsents { get; set; } = [];
    }
}
