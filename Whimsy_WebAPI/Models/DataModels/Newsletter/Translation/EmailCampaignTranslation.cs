using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo;
using Whimsy_WebAPI.Enums.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Newsletter.Translation
{
    /// <summary>
    /// Represents a translated version of an email campaign in a specific language.
    /// </summary>
    [Table("EmailCampaignTranslations")]
    public class EmailCampaignTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated email campaign.
        /// </summary>
        [Required]
        public int EmailCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the email campaign associated with a translation.
        /// This navigation property links to the <see cref="EmailCampaign"/>.
        /// </summary>
        [ForeignKey(nameof(EmailCampaignId))]
        public virtual EmailCampaign EmailCampaign { get; set; } = null!;

        /// <summary>
        /// Gets or sets the subject of the email campaign.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the body content of the email campaign.
        /// </summary>
        [Required]
        public string Body { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
