using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Models.DataModels.Newsletter;

namespace Whimsy_WebAPI.Models.DataModels.Shipping.Translation
{
    /// <summary>
    /// Represents a translated version of a shipping method in a specific language.
    /// </summary>
    [Table("ShippingMethodTranslations")]
    public class ShippingMethodTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated shipping method.
        /// </summary>
        [Required]
        public int ShippingMethodId { get; set; }

        /// <summary>
        /// Gets or sets the email campaign associated with a translation.
        /// This navigation property links to the <see cref="ShippingMethod"/>.
        /// </summary>
        [ForeignKey(nameof(ShippingMethodId))]
        public virtual ShippingMethod ShippingMethod { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the delivery method.
        /// This property is initialized to an empty string to avoid null values.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the delivery method.
        /// This property is nullable to accommodate cases where no description is provided.
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the language code for this email campagne.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
