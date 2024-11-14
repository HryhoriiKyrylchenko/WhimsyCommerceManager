using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Enums.Shipping;
using Whimsy_WebAPI.Models.DataModels.Common;
using Whimsy_WebAPI.Models.DataModels.Purchase;

namespace Whimsy_WebAPI.Models.DataModels.Shipping
{
    /// <summary>
    /// Represents a delivery entity.
    /// </summary>
    [Table("Shipments")]
    public class Shipment
    {
        /// <summary>
        /// Gets or sets the delivery ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the order ID associated with the delivery.
        /// </summary>
        [Required]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the order associated with the delivery.
        /// </summary>
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        /// <summary>
        /// Gets or sets the selected shipping option for this delivery.
        /// </summary>
        [Required]
        public int ShippingOptionId { get; set; }

        /// <summary>
        /// Gets or sets the shipping option with the delivery.
        /// </summary>
        [ForeignKey(nameof(ShippingOptionId))]
        public virtual ShippingOption ShippingOption { get; set; } = null!;

        /// <summary>
        /// Gets or sets the delivery address.
        /// </summary>
        public int? ShippingAddressId { get; set; }

        /// <summary>
        /// Gets or sets the address associated with the delivery.
        /// </summary>
        [ForeignKey(nameof(ShippingAddressId))]
        public virtual Address? ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets the location where the order can be picked up by the customer.
        /// This property is nullable to accommodate cases where a pickup point is not specified.
        /// </summary>
        public string? PickupPoint { get; set; }


        /// <summary>
        /// Gets or sets the expected delivery date.
        /// </summary>
        public DateTime? ExpectedShippingDate { get; set; }

        /// <summary>
        /// Gets or sets the status of the delivery.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public ShippingStatus Status { get; set; }
    }
}
