using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Whimsy_WebAPI.Models.DataModels.Shipping
{
    /// <summary>
    /// Represents the cost and estimated delivery time for a specific delivery option.
    /// </summary>
    [Table("ShippingOptions")]
    public class ShippingOption
    {
        /// <summary>
        /// Gets or sets the unique identifier for the shipping option.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the delivery method associated with this option.
        /// </summary>
        [Required]
        public int ShippingMethodId { get; set; }

        /// <summary>
        /// Gets or sets the delivery method associated with this option.
        /// </summary>
        [ForeignKey(nameof(ShippingMethodId))]
        public virtual ShippingMethod ShippingMethod { get; set; } = null!;

        /// <summary>
        /// Gets or sets the cost of using this shipping option.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than zero.")]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets the estimated delivery time for this shipping option.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string EstimatedDeliveryTime { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the free shipping flag.
        /// </summary>
        public bool IsFreeShipping { get; set; } = false;

        /// <summary>
        /// Gets or sets the availability status of this shipping option.
        /// </summary>
        [Required]
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// Gets or sets the collection of shipping options associated with this delivery method.
        /// </summary>
        public virtual ICollection<Shipment> Shipments { get; set; } = [];
    }
}
