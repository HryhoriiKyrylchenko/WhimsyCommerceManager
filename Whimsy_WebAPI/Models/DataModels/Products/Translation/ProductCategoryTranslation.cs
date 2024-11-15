using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Products.Translation
{
    /// <summary>
    /// Represents a translated version of a product category in a specific language.
    /// </summary>
    [Table("ProductCategoryTranslations")]
    [Index(nameof(Name), IsUnique = true)]
    public class ProductCategoryTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated product category.
        /// </summary>
        [Required]
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the broduct category associated with a translation.
        /// This navigation property links to the <see cref="ProductCategory"/>.
        /// </summary>
        [ForeignKey(nameof(ProductCategoryId))]
        public virtual ProductCategory ProductCategory { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the category.
        /// </summary>
        [MaxLength(255)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
