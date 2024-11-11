﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;

namespace Whimsy_WebAPI.Models.DataModels.Discounts
{
    /// <summary>
    /// Represents the many-to-many relationship between customers and coupons.
    /// </summary>
    [Table("CustomersCoupons")]
    public class CustomerCoupon
    {
        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        [Required]
        public string CustomerId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the customer associated with the coupon.
        /// </summary>
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Coupon ID.
        /// </summary>
        [Required]
        public int CouponId { get; set; }

        /// <summary>
        /// Gets or sets the coupon associated with the customer.
        /// </summary> 
        [ForeignKey(nameof(CouponId))]
        public virtual Coupon Coupon { get; set; } = null!;
    }
}
