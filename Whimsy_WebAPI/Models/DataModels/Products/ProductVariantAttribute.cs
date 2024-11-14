using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Products
{
    /// <summary>
    /// Represents an attribute of a product variant, such as size, color, or other characteristics.
    /// </summary>
    [Table("ProductVariantAttributes")]
    public class ProductVariantAttribute
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product variant attribute.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated product variant.
        /// This is a foreign key linking to the <see cref="ProductVariant"/> entity.
        /// </summary>
        [Required]
        public int ProductVariantId { get; set; }

        /// <summary>
        /// Gets or sets the associated product variant.
        /// This navigation property provides access to the parent <see cref="ProductVariant"/>.
        /// </summary>
        [ForeignKey(nameof(ProductVariantId))]
        public virtual ProductVariant ProductVariant { get; set; } = null!;

        /// <summary>
        /// Gets or sets the translation for the product variant attribute.
        /// </summary>
        public virtual ICollection<ProductVariantAttributeTranslation> Translations { get; set; } = [];
    }
}
