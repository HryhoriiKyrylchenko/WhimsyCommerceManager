﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Utilities;

namespace Whimsy_WebAPI.Models.DataModels.MarketplaceInfo
{
    /// <summary>
    /// Represents return policies for marketplace products.
    /// </summary>
    [Table("MarketplaceReturns")]
    public class MarketplaceReturns
    {
        /// <summary>
        /// Gets or sets the unique identifier for the return policy.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the last updated date for the return policy.
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
        /// Gets or sets the version of the return policy.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the translation for the marketplace returns.
        /// </summary>
        public virtual ICollection<MarketplaceReturnsTranslation> Translations { get; set; } = [];
    }
}