using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Models.DataModels.Newsletter;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement.Translation
{
    /// <summary>
    /// Represents a translated version of a seller info in a specific language.
    /// </summary>
    [Table("SellerTranslations")]
    public class SellerTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated seller.
        /// </summary>
        [Required]
        public string SellerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the seller associated sellet translation.
        /// This navigation property links to the <see cref="Seller"/>.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the shop.
        /// </summary>
        public string ShopName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the shop.
        /// </summary>
        public string ShopDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the language code for this email campagne.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
