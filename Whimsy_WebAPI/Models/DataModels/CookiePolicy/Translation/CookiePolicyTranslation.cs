using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Enums.Translation;

namespace Whimsy_WebAPI.Models.DataModels.CookiePolicy.Translation
{
    /// <summary>
    /// Represents a translated version of a cookie policy in a specific language.
    /// </summary>
    [Table("CookiePolicyTranslations")]
    public class CookiePolicyTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated cookie policy.
        /// </summary>
        [Required]
        public int CookiePolicyId { get; set; }

        /// <summary>
        /// Gets or sets the cookie policy associated with a translation.
        /// This navigation property links to the <see cref="CookiePolicy"/>.
        /// </summary>
        [ForeignKey(nameof(CookiePolicyId))]
        public virtual CookiePolicy CookiePolicy { get; set; } = null!;

        /// <summary>
        /// Gets or sets the text content of the cookie policy. 
        /// This may be null if no text is provided.
        /// </summary>
        public string? PolicyText { get; set; }

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }

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
    }
}
