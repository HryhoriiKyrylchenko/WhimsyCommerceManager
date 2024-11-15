﻿namespace Whimsy_WebAPI.Enums.LogEnums
{
    /// <summary>
    /// Represents the types of user activities tracked in the system.
    /// </summary>
    public enum ActivityType
    {
        /// <summary>
        /// Indicates a user login event.
        /// </summary>
        Login,

        /// <summary>
        /// Indicates a user logout event.
        /// </summary>
        Logout,

        /// <summary>
        /// Indicates that a user has viewed a product.
        /// </summary>
        ViewProduct,

        /// <summary>
        /// Indicates that a user has added a product to their shopping cart.
        /// </summary>
        AddToCart,

        /// <summary>
        /// Indicates that a user has completed a purchase.
        /// </summary>
        Purchase,

        /// <summary>
        /// Indicates that a user has returned a purchase.
        /// </summary>
        Return,

        /// <summary>
        /// Indicates that a user has updates his profile.
        /// </summary>
        ProfileUpdate,

        /// <summary>
        /// Indicates that a user was blocked.
        /// </summary>
        UserBlocked,

        /// <summary>
        /// Indicates that a user was unblocked.
        /// </summary>
        UserUnblocked,

        /// <summary>
        /// Indicates that a user has changed his password.
        /// </summary>
        PasswordChange,

        /// <summary>
        /// Indicates that a user has changed his subscription.
        /// </summary>
        SubscriptionChange,

        /// <summary>
        /// Indicates that a seller has added a new product to the marketplace.
        /// </summary>
        SellerAddProduct,

        /// <summary>
        /// Indicates that a seller has updated a product's details.
        /// </summary>
        SellerUpdateProduct,

        /// <summary>
        /// Indicates that a seller has removed a product from the marketplace.
        /// </summary>
        SellerRemoveProduct,

        /// <summary>
        /// Indicates that a seller has updated their inventory levels for a product.
        /// </summary>
        SellerUpdateInventory,

        /// <summary>
        /// Indicates that a seller has processed an order.
        /// </summary>
        SellerProcessOrder,

        /// <summary>
        /// Indicates that a seller has requested a refund for an order.
        /// </summary>
        SellerRequestRefund,

        /// <summary>
        /// Indicates that a seller has received a payout.
        /// </summary>
        SellerReceivePayout,

        /// <summary>
        /// Indicates that a user complited other action.
        /// </summary>
        Other,
    }
}
