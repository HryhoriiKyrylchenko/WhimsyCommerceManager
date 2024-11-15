using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Newsletter.Translation;
using Whimsy_WebAPI.Models.DataModels.Products.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Products
{
    /// <summary>
    /// Represents a product bundle that includes multiple products sold together at a discount.
    /// </summary>
    [Table("ProductBundles")]
    public class ProductBundle
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the total price for the bundle.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the date when the bundle was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the products included in the bundle.
        /// </summary>
        public virtual ICollection<ProductBundleItem> ProductBundleItems { get; set; } = [];

        /// <summary>
        /// Gets or sets the translation for the product bundle.
        /// </summary>
        public virtual ICollection<ProductBundleTranslation> Translations { get; set; } = [];
    }
}
