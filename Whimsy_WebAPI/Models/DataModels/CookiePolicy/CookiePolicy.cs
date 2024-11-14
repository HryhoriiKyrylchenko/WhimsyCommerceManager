using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Whimsy_WebAPI.Models.DataModels.CookiePolicy.Translation;
using Whimsy_WebAPI.Models.DataModels.Products.Translation;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Utilities;

namespace Whimsy_WebAPI.Models.DataModels.CookiePolicy
{
    /// <summary>
    /// Represents the cookie policy with versioning and content details.
    /// </summary>
    [Table("CookiePolicies")]
    public class CookiePolicy
    {
        /// <summary>
        /// Gets or sets the unique identifier for the cookie policy.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the version of the cookie policy. 
        /// This could represent a versioning system (e.g., 1.0.0).
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last updated date of the cookie policy.
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
        /// Gets or sets the flag indicating whether the policy is active.
        /// If false, it means the policy is no longer in effect.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the translation for the cookie policy.
        /// </summary>
        public virtual ICollection<CookiePolicyTranslation> Translations { get; set; } = [];
    }
}
