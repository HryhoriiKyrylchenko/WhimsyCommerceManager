using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.Newsletter.Translation;
using Whimsy_WebAPI.Models.DataModels.Shipping.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Shipping
{
    /// <summary>
    /// Represents a delivery method that can be used for shipping orders.
    /// </summary>
    [Table("ShippingMethods")]
    public class ShippingMethod
    {
        /// <summary>
        /// Gets or sets the unique identifier for the delivery method.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the availability status of the shipping method.
        /// </summary>
        [Required]
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// Gets or sets the collection of shipping options associated with this delivery method.
        /// </summary>
        public virtual ICollection<ShippingOption> ShippingOptions { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of customer shipping methods associated with this payment method.
        /// </summary>
        public virtual ICollection<CustomerShippingMethod> CustomerShippingMethods { get; set; } = [];

        /// <summary>
        /// Gets or sets the translation for the shipping method.
        /// </summary>
        public virtual ICollection<ShippingMethodTranslation> Translations { get; set; } = [];
    }
}
