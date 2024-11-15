using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Whimsy_WebAPI.Models.DataModels.Support;
using Whimsy_WebAPI.Models.DataModels.CartsAndFavourites;
using Whimsy_WebAPI.Models.DataModels.Analytics;
using Whimsy_WebAPI.Models.DataModels.Newsletter;
using Whimsy_WebAPI.Models.DataModels.Products;
using Whimsy_WebAPI.Models.DataModels.Discounts;
using Whimsy_WebAPI.Models.DataModels.Shipping;
using Whimsy_WebAPI.Models.DataModels.Purchase;
using Whimsy_WebAPI.Models.DataModels.Finance;
using Whimsy_WebAPI.Models.DataModels.Messaging;

namespace Whimsy_WebAPI.Models.DataModels.UserManagement
{
    /// <summary>
    /// Represents a customer entity.
    /// </summary>
    [Table("Customers")]
    public class Customer
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        [Key]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user associated with this entity.
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the unique identifier provided by Google for the user.
        /// This property is nullable to accommodate users who may not use Google for authentication.
        /// </summary>
        public string? GoogleId { get; set; }

        /// <summary>
        /// Indicates whether the customer is blocked from accessing their account.
        /// </summary>
        public bool IsBlocked { get; set; }

        /// <summary>
        /// The date when the customer was blocked, if applicable.
        /// </summary>
        public DateTime? BlockedDate { get; set; }

        /// <summary>
        /// The reason for blocking the customer, if applicable.
        /// </summary>
        public string? BlockedReason { get; set; }

        /// <summary>
        /// Gets or sets the collection of orders associated with the user.
        /// This collection is initialized to an empty list to avoid null reference issues.
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of customer payment methods associated with the coupon.
        /// </summary>
        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethods { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of customer shipping methods associated with the coupon.
        /// </summary>
        public virtual ICollection<CustomerShippingMethod> CustomerShippingMethods { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of customer coupons associated with the coupon.
        /// </summary>
        public virtual ICollection<CustomerCoupon> CustomersCoupons { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of product reviews associated with the coupon.
        /// </summary>
        public virtual ICollection<ProductReview> ProductReviews { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of shopping carts associated with the coupon.
        /// </summary>
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of favorite products associated with the customer.
        /// </summary>
        public virtual ICollection<ProductFavorite> ProductFavorites { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of favorite categories associated with the customer.
        /// </summary>
        public virtual ICollection<CategoryFavorite> CategoryFavorites { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of support tickets associated with the customer.
        /// </summary>
        public virtual ICollection<SupportTicket> SupportTickets { get; set; } = [];

        /// <summary>
        /// Gets or sets the customer segmentation associated with the customer.
        /// </summary>
        public virtual CustomerSegmentation? CustomerSegmentation { get; set; }

        /// <summary>
        /// Gets or sets the collection of newsletter subscriptions associated with the user.
        /// </summary>
        public virtual ICollection<NewsletterSubscription> NewsletterSubscriptions { get; set; } = [];

        /// <summary>
        /// Gets or sets the list of conversations associated with the customer.
        /// </summary>
        public virtual ICollection<Conversation> Conversations { get; set; } = [];
    }
}
