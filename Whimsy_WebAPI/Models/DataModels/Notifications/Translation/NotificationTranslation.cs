using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whimsy_WebAPI.Enums.Translation;
using Whimsy_WebAPI.Models.DataModels.Products;

namespace Whimsy_WebAPI.Models.DataModels.Notifications.Translation
{
    /// <summary>
    /// Represents a translated version of a notification in a specific language.
    /// </summary>
    [Table("NotificationTranslations")]
    public class NotificationTranslation
    {
        /// <summary>
        /// Gets or sets the unique identifier of the translation.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated notification.
        /// </summary>
        [Required]
        public int NotificationId { get; set; }

        /// <summary>
        /// Gets or sets the notification associated with a translation.
        /// This navigation property links to the <see cref="Notification"/>.
        /// </summary>
        [ForeignKey(nameof(NotificationId))]
        public virtual Notification Notification { get; set; } = null!;

        /// <summary>
        /// Gets or sets the content of the notification.
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the language code for this entity.
        /// </summary>
        [Required]
        public LanguageCode LanguageCode { get; set; }
    }
}
