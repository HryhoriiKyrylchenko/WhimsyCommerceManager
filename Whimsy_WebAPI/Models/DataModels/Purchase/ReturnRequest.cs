﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Purchase;

namespace Whimsy_WebAPI.Models.DataModels.Purchase
{
    /// <summary>
    /// Represents a return request entity.
    /// </summary>
    [Table("ReturnRequests")]
    public class ReturnRequest
    {
        /// <summary>
        /// Gets or sets the return request ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the order ID associated with the return request.
        /// </summary>
        [Required]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the order associated with the return request.
        /// </summary>
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date when the return request was created.
        /// </summary>
        [Required]
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the return request was processed (if applicable).
        /// </summary>
        public DateTime? ProcessedDate { get; set; }

        /// <summary>
        /// Gets or sets the reason for the return request.
        /// </summary>
        [Required]
        [MaxLength(500)]
        public string Reason { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the status of the return request.
        /// </summary>
        [Required]
        public ReturnRequestStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the collection of notes associated with the return request.
        /// </summary>
        public virtual ICollection<ReturnNote> ReturnNotes { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of return request items.
        /// </summary>
        public virtual ICollection<ReturnRequestItem> ReturnRequestItems { get; set; } = [];
    }
}
