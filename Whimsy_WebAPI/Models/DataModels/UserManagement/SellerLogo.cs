using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement
{
    /// <summary>
    /// Represents a logo for a seller on the marketplace.
    /// </summary>
    [Table("SellerLogos")]
    public class SellerLogo
    {
        /// <summary>
        /// Gets or sets the unique identifier for the seller logo.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the seller's unique identifier.
        /// This is a foreign key linking to the <see cref="Seller"/> entity.
        /// </summary>
        [Required]
        public int SellerId { get; set; }

        /// <summary>
        /// Gets or sets the associated seller.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the image path for the logo.
        /// </summary>
        [Required]
        public string LogoPath { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the image format (e.g., png, jpg).
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string ImageFormat { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date when the logo was uploaded.
        /// </summary>
        [Required]
        public DateTime UploadDate { get; set; }

        /// <summary>
        /// Version of the entity for optimistic concurrency control.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
