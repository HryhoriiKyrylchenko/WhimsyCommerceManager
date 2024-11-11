﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Enums.LogEnums;

namespace Whimsy_WebAPI.Models.DataModels.LogModels
{
    /// <summary>
    /// Represents a log of user activities within the system.
    /// </summary>
    [Table("UserActivityLogs")]
    [Index(nameof(UserId), nameof(ActivityDate))]
    public class UserActivityLog
    {
        /// <summary>
        /// Gets or sets the log ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who performed the activity.
        /// </summary>
        [Required]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user associated with this activity.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>ы
        /// Gets or sets the type of the activity (e.g., login, order creation).
        /// </summary>
        [Required]
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// Gets or sets the description of the activity.
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the IP address from where the activity was performed.
        /// </summary>
        [MaxLength(50)]
        public string? IPAddress { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the activity occurred.
        /// </summary>
        [Required]
        public DateTime ActivityDate { get; set; }

        /// <summary>
        /// Gets or sets the old data (for editing and blocking).
        /// </summary>
        [MaxLength(1000)]
        public string? OldData { get; set; }

        /// <summary>
        /// Gets or sets the new data (for editing and blocking).
        /// </summary>
        [MaxLength(1000)]
        public string? NewData { get; set; }
    }
}
