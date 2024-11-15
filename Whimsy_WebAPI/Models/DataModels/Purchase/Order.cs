using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Purchase;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Models.DataModels.Finance;
using Whimsy_WebAPI.Models.DataModels.Shipping;

namespace Whimsy_WebAPI.Models.DataModels.Purchase
{
    /// <summary>
    /// Represents an order entity.
    /// </summary>
    [Table("Orders")]
    public class Order
    {
        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the order.
        /// </summary>
        [Required]
        public string CustomerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the customer associated with the order.
        /// </summary>
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date of the order.
        /// </summary>
        [Required]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the total sum of the order.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalOrderSum { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        [Required]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Version of the entity for optimistic concurrency control.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of order items associated with the order.
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of transactions associated with the order.
        /// </summary>
        public virtual ICollection<Transaction> Transactions { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of shipments associated with the order.
        /// </summary>
        public virtual ICollection<Shipment> Shipments { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of return requests associated with the order.
        /// </summary>
        public virtual ICollection<ReturnRequest> ReturnRequests { get; set; } = [];
    }
}
