using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Products.Translation
{
    /// <summary>
    /// Represents a translated version of a product variant in a specific language.
    /// </summary>
    [Table("ProductVariantTranslations")]
    public class ProductVariantTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated product variant.
        /// </summary>
        [Required]
        public int ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the broduct variant associated with a translation.
        /// This navigation property links to the <see cref="ProductVariant"/>.
        /// </summary>
        [ForeignKey(nameof(ProductVariantId))]
        public virtual ProductVariant ProductVariant { get; set; } = null!;

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
