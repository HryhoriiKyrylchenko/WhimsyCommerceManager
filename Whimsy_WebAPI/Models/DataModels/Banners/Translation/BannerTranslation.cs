using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Models.DataModels.Products;

namespace Whimsy_WebAPI.Models.DataModels.Banners.Translation
{
    /// <summary>
    /// Represents a translated version of a banner in a specific language.
    /// </summary>
    [Table("BannerTranslation")]
    public class BannerTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated banner.
        /// </summary>
        [Required]
        public int BannerId { get; set; }

        /// <summary>
        /// Gets or sets the banner associated with a translation.
        /// This navigation property links to the <see cref="Banner"/>.
        /// </summary>
        [ForeignKey(nameof(BannerId))]
        public virtual Banner Banner { get; set; } = null!;

        /// <summary>
        /// Gets or sets the title of the banner.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the image for the banner.
        /// </summary>
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
