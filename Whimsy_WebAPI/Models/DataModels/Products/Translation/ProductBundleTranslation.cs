using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Models.DataModels.Newsletter;

namespace Whimsy_WebAPI.Models.DataModels.Products.Translation
{
    /// <summary>
    /// Represents a translated version of a product bundle in a specific language.
    /// </summary>
    [Table("ProductBundleTranslations")]
    public class ProductBundleTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated product bundle.
        /// </summary>
        [Required]
        public int ProductBundleId { get; set; }

        /// <summary>
        /// Gets or sets the product bundle associated with a translation.
        /// This navigation property links to the <see cref="ProductBundle"/>.
        /// </summary>
        [ForeignKey(nameof(ProductBundleId))]
        public virtual ProductBundle ProductBundle { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the bundle (e.g., "Holiday Gift Set").
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the product bundle.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
