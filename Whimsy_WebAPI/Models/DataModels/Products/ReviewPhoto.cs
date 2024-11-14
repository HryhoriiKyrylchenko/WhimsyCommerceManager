using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Whimsy_WebAPI.Models.DataModels.Products
{
    /// <summary>
    /// Represents a photo attached to a product review.
    /// </summary>
    [Table("ReviewPhotos")]
    public class ReviewPhoto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the review photo.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated product review.
        /// This is a foreign key linking to the <see cref="ProductReview"/> entity.
        /// </summary>
        [Required]
        public int ProductReviewId { get; set; }

        /// <summary>
        /// Gets or sets the associated product review.
        /// </summary>
        [ForeignKey(nameof(ProductReviewId))]
        public virtual ProductReview ProductReview { get; set; } = null!;

        /// <summary>
        /// Gets or sets the image data for the review photo.
        /// </summary>
        [Required]
        public byte[] PhotoData { get; set; } = null!;

        /// <summary>
        /// Gets or sets the image format (e.g., png, jpg).
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string ImageFormat { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date when the photo was uploaded.
        /// </summary>
        [Required]
        public DateTime UploadDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Version of the entity for optimistic concurrency control.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
