﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Models.DataModels.Inventory;

namespace Whimsy_WebAPI.Models.DataModels.Common
{
    /// <summary>
    /// Represents an address entity.
    /// </summary>
    [Table("Addresses")]
    public class Address
    {
        /// <summary>
        /// Gets or sets the address ID.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the house or building number of the address.
        /// </summary>
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z0-9\s\-]+$", ErrorMessage = "Invalid house number format.")]
        public string? BuildingNumber { get; set; }

        /// <summary>
        /// Gets or sets the unit number of the address (if applicable).
        /// </summary>
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z0-9\s\-]+$", ErrorMessage = "Invalid apartment number format.")]
        public string? UnitNumber { get; set; }

        /// <summary>
        /// Gets or sets the street of the address.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the city of the address.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the state of the address.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the postal code of the address.
        /// </summary>
        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid postal code format.")]
        public string PostalCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the country of the address.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of shipments associated with the address.
        /// </summary>
        public virtual ICollection<Shipment> Shipments { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of user addresses associated with the address.
        /// </summary>
        public virtual ICollection<UserAddress> UserAddresses { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of warehouses associated with the address.
        /// </summary>
        public virtual ICollection<Warehouse> Warehouses { get; set; } = [];
    }
}
