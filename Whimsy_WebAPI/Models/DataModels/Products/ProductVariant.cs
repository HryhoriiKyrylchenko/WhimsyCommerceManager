﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Models.DataModels.Inventory;
using Whimsy_WebAPI.Models.DataModels.CartsAndFavourites;
using Whimsy_WebAPI.Models.DataModels.Analytics;
using Whimsy_WebAPI.Models.DataModels.Purchase;
using Whimsy_WebAPI.Models.DataModels.Discounts;
using Whimsy_WebAPI.Models.DataModels.Products.Translation;

namespace Whimsy_WebAPI.Models.DataModels.Products
{
    /// <summary>
    /// Represents a specific variant of a product, such as a unique size, color, or other differentiating attribute.
    /// </summary>
    [Table("ProductVariants")]
    public class ProductVariant
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product variant.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated product.
        /// This is a foreign key linking to the <see cref="Product"/> entity.
        /// </summary>
        [Required]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the associated product for this variant.
        /// This navigation property provides access to the parent <see cref="Product"/>.
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier of the associated seller.
        /// This is a foreign key linking to the <see cref="Seller"/> entity.
        /// </summary>
        [Required]
        public int SellerId { get; set; }

        /// <summary>
        /// Gets or sets the associated seller for this variant.
        /// This navigation property provides access to the <see cref="Seller"/>.
        /// </summary>
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;

        /// <summary>
        /// Gets or sets the SKU (Stock Keeping Unit) for the product variant.
        /// This is a required unique identifier for each variant.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string SKU { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price for the product variant.
        /// The price is required and must be a positive value, stored as a decimal with 18 digits of precision and 2 decimal places.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets whether the product is visible to customers.
        /// </summary>
        [Required]
        public bool IsVisible { get; set; } = true;

        /// <summary>
        /// Estimated time (in days) to dispatch the item after order.
        /// </summary>
        [Range(0, 365, ErrorMessage = "Dispatch time must be between 0 and 365 days.")]
        public int DispatchTimeInDays { get; set; } = 0;

        /// <summary>
        /// Gets or sets the user ID of the person who last edited the product.
        /// </summary>
        public string? LastEditedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the user who last edited the product.
        /// </summary>
        [ForeignKey(nameof(LastEditedByUserId))]
        public virtual ApplicationUser? LastEditedByUser { get; set; }

        /// <summary>
        /// Gets or sets the date when the product was last edited.
        /// </summary>
        public DateTime? LastEditedDate { get; set; }

        /// <summary>
        /// The number of units sold for this product variant.
        /// </summary>
        public int SoldQuantity { get; set; } = 0;

        /// <summary>
        /// Version of the entity for optimistic concurrency control.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of inventory items associated with this product variant.
        /// Inventory item represents a display of a product variant in stock.
        /// </summary>
        public virtual ICollection<InventoryItem> InventoryItems { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of attributes associated with this product variant.
        /// Attributes represent additional characteristics of the variant, such as color or size.
        /// </summary>
        public virtual ICollection<ProductVariantAttribute> Attributes { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of product images associated with the product variant.
        /// </summary>
        public virtual ICollection<ProductImage> ProductImages { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of order items associated with the product variant.
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of products discounts associated with the product variant.
        /// </summary>
        public virtual ICollection<ProductVariantDiscount> ProductVariantsDiscounts { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of return request items associated with the product variant.
        /// </summary>
        public virtual ICollection<ReturnRequestItem> ReturnRequestItems { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of shopping cart items associated with the product variant.
        /// </summary>
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of favorite products associated with the product variant.
        /// </summary>
        public virtual ICollection<ProductFavorite> ProductFavorites { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of price histories associated with the product variant.
        /// </summary>
        public virtual ICollection<PriceHistory> PriceHistories { get; set; } = [];

        /// <summary>
        /// Gets or sets the collection of sales analitics associated with the product variant.
        /// </summary>
        public virtual ICollection<SalesAnalytics> SalesAnalytics { get; set; } = [];

        /// <summary>
        /// Gets or sets the translation for the product variant.
        /// </summary>
        public virtual ICollection<ProductVariantTranslation> Translations { get; set; } = [];
    }
}
