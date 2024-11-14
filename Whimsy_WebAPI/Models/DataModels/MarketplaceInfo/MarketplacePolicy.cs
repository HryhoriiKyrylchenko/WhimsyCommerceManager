using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Utilities;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo
{
    /// <summary>
    /// Represents a marketplace policy, including title, content, version, and status.
    /// </summary>
    [Table("MarketplacePolicies")]
    public class MarketplacePolicy
    {
        /// <summary>
        /// Gets or sets the unique identifier for the policy.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the policy was last updated.
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
        /// Gets or sets whether the policy is active and in use.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the version of the policy.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Optimistic concurrency control field for handling versioning of the policy record.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;

        /// <summary>
        /// Gets or sets the translation for the marketplace policies.
        /// </summary>
        public virtual ICollection<MarketplacePolicyTranslation> Translations { get; set; } = [];
    }
}
