﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Notifications;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Models.DataModels.Products.Translation;
using Whimsy_WebAPI.Models.DataModels.Notifications.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Notifications
{
    /// <summary>
    /// Represents a notification for users.
    /// </summary>
    [Table("Notifications")]
    [Index(nameof(UserId), nameof(CreatedAt))]
    public class Notification
    {
        /// <summary>
        /// Gets or sets the notification ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID associated with the notification.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the customer associated with this entity.
        /// This navigation property provides access to the related <see cref="ApplicationUser"/> entity.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the type of the notification.
        /// </summary>
        [Required]
        public NotificationType Type { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the notification was created.
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets whether the notification has been read.
        /// </summary>
        public bool IsRead { get; set; } = false;

        /// <summary>
        /// Gets or sets the translation for the notification.
        /// </summary>
        public virtual ICollection<NotificationTranslation> Translations { get; set; } = [];
    }
}
