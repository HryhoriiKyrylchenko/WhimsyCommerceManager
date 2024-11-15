using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Utilities;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo
{
    /// <summary>
    /// Represents the partnership agreements for the marketplace.
    /// </summary>
    [Table("MarketplacePartnerships")]
    public class MarketplacePartnership
    {
        /// <summary>
        /// Gets or sets the unique identifier for the partnership.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the last updated date for the partnership.
        /// </summary>
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
        /// Gets or sets the version of the partnership agreement.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the status of the partnership (active or inactive).
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Optimistic concurrency control field for handling versioning of the record.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;

        /// <summary>
        /// Gets or sets the translation for the marketplace partnership.
        /// </summary>
        public virtual ICollection<MarketplacePartnershipTranslation> Translations { get; set; } = [];
    }
}
