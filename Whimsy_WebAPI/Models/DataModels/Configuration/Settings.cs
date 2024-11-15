﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Configuration;

namespace Whimsy_WebAPI.Models.DataModels.Configuration
{
    /// <summary>
    /// Represents the settings entity for storing application-wide configurations.
    /// </summary>
    [Table("Settings")]
    public class Settings
    {
        /// <summary>
        /// Gets or sets the ID of the setting.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the setting (key).
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the value of the setting.
        /// This field is stored as JSON to accommodate various types (string, int, bool, etc.).
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a description for the setting.
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the setting type (string, int, bool, etc.).
        /// </summary>
        [Required]
        [EnumDataType(typeof(SettingType))]
        public SettingType SettingType { get; set; }

        /// <summary>
        /// Gets or sets the date when the setting was last updated.
        /// </summary>
        [Required]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
