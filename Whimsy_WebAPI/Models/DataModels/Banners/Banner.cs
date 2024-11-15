using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Banner;

namespace Whimsy_WebAPI.Models.DataModels.Banners
{
    /// <summary>
    /// Represents a banner for display on different pages of the platform.
    /// </summary>
    [Table("Banners")]
    public class Banner
    {
        /// <summary>
        /// Gets or sets the unique identifier for the banner.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the URL the banner should link to when clicked.
        /// </summary>
        public string? LinkUrl { get; set; }

        /// <summary>
        /// Gets or sets the page where the banner should be displayed (e.g., Homepage, CategoryPage).
        /// </summary>
        [Required]
        public BannerPageLocation PageLocation { get; set; }

        /// <summary>
        /// Gets or sets the display order for banners on the same page.
        /// </summary>
        [Required]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the start date for the banner to be active.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date for the banner to be active.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks if the banner is currently active.
        /// </summary>
        public bool IsActive =>
            (!StartDate.HasValue || StartDate <= DateTime.UtcNow) &&
            (!EndDate.HasValue || EndDate > DateTime.UtcNow);
    }
}
