using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Products;
using Whimsy_WebAPI.Enums.Inventory;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Microsoft.EntityFrameworkCore;

namespace Whimsy_WebAPI.Models.DataModels.Inventory
{
    /// <summary>
    /// Represents a label associated with a product for identification purposes, such as barcodes or QR codes.
    /// </summary>
    [Table("Labels")]
    public class Label
    {
        /// <summary>
        /// Gets or sets the unique identifier for the label.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the code for the label, such as a barcode or QR code.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the code (e.g., Barcode, QRCode).
        /// </summary>
        [Required]
        public LabelType CodeType { get; set; }

        /// <summary>
        /// Gets or sets the inventory item associated with this label.
        /// </summary>
        [Required]
        public int InventoryItemId { get; set; }

        /// <summary>
        /// Gets or sets the inventory item associated with this label.
        /// </summary>
        [ForeignKey(nameof(InventoryItemId))]
        public virtual InventoryItem InventoryItem { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date when the label was created.
        /// </summary>
        [Required]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the label was last updated.
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the status of the label (e.g., active, inactive).
        /// </summary>
        [Required]
        public LabelStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the description or additional information about the label.
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets ID of the user who last updated the label.
        /// </summary>
        public string? LastUpdatedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the user who last updated the label.
        /// </summary>
        [ForeignKey(nameof(LastUpdatedByUserId))]
        public virtual ApplicationUser? LastUpdatedByUser { get; set; }

        /// <summary>
        /// Gets or sets any associated activity or status tracking information.
        /// </summary>
        public string? ActivityStatus { get; set; }
    }
}
