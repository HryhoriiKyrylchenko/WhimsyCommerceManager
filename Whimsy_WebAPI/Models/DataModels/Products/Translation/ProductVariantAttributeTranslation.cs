using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Products.Translation
{
    /// <summary>
    /// Represents a translated version of a product variant attribute in a specific language.
    /// </summary>
    [Table("ProductVariantAttributeTranslations")]
    public class ProductVariantAttributeTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated product variant attribute.
        /// </summary>
        [Required]
        public int ProductVariantAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the broduct variant attribute associated with a translation.
        /// This navigation property links to the <see cref="ProductVariantAttribute"/>.
        /// </summary>
        [ForeignKey(nameof(ProductVariantAttributeId))]
        public virtual ProductVariantAttribute ProductVariantAttribute { get; set; } = null!;

        /// <summary>
        /// Gets or sets the key or name of the attribute.
        /// This could be a property such as "Color" or "Size".
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the value of the attribute.
        /// This could be the specific value for the attribute, such as "Black" or "Large".
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
