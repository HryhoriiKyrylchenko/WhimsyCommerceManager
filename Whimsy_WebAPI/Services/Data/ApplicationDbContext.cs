using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Whimsy_WebAPI.Models.DataModels.Analytics;
using Whimsy_WebAPI.Models.DataModels.Banners;
using Whimsy_WebAPI.Models.DataModels.Banners.Translation;
using Whimsy_WebAPI.Models.DataModels.CartsAndFavourites;
using Whimsy_WebAPI.Models.DataModels.Common;
using Whimsy_WebAPI.Models.DataModels.Configuration;
using Whimsy_WebAPI.Models.DataModels.CookiePolicy;
using Whimsy_WebAPI.Models.DataModels.CookiePolicy.Translation;
using Whimsy_WebAPI.Models.DataModels.Discounts;
using Whimsy_WebAPI.Models.DataModels.Finance;
using Whimsy_WebAPI.Models.DataModels.Inventory;
using Whimsy_WebAPI.Models.DataModels.LogModels;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo;
using Whimsy_WebAPI.Models.DataModels.MarketplaceInfo.Translation;
using Whimsy_WebAPI.Models.DataModels.Messaging;
using Whimsy_WebAPI.Models.DataModels.Newsletter;
using Whimsy_WebAPI.Models.DataModels.Newsletter.Translation;
using Whimsy_WebAPI.Models.DataModels.Notifications;
using Whimsy_WebAPI.Models.DataModels.Notifications.Translation;
using Whimsy_WebAPI.Models.DataModels.Products;
using Whimsy_WebAPI.Models.DataModels.Products.Translation;
using Whimsy_WebAPI.Models.DataModels.Purchase;
using Whimsy_WebAPI.Models.DataModels.Shipping;
using Whimsy_WebAPI.Models.DataModels.Shipping.Translation;
using Whimsy_WebAPI.Models.DataModels.Support;
using Whimsy_WebAPI.Models.DataModels.UserManagement;
using Whimsy_WebAPI.Models.DataModels.UserManagement.Translation;

namespace Whimsy_WebAPI.Services.Data
{
    /// <summary>
    /// Represents the application's database context.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
    /// </remarks>
    /// <param name="options">The options to be used by a <see cref="DbContext"/>.</param>
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        /// <summary>
        /// Gets or sets the abandoned carts in the database.
        /// </summary>
        public DbSet<AbandonedCart>? AbandonedCarts { get; set; }

        /// <summary>
        /// Gets or sets the addresses in the database.
        /// </summary>
        public DbSet<Address>? Addresses { get; set; }

        /// <summary>
        /// Gets or sets the users in the database.
        /// </summary>
        public DbSet<ApplicationUser>? ApplicationUsers { get; set; }

        /// <summary>
        /// Gets or sets the audit log in the database.
        /// </summary>
        public DbSet<AuditLog>? AuditLogs { get; set; }

        /// <summary>
        /// Gets or sets the banners in the database.
        /// </summary>
        public DbSet<Banner>? Banners { get; set; }

        /// <summary>
        /// Gets or sets the banner translations in the database.
        /// </summary>
        public DbSet<BannerTranslation>? BannerTranslations { get; set; }

        /// <summary>
        /// Gets or sets the categories and discounts in the database.
        /// </summary>
        public DbSet<CategoryDiscount>? CategoryDiscounts { get; set; }

        /// <summary>
        /// Gets or sets the favorite categories in the database.
        /// </summary>`
        public DbSet<CategoryFavorite>? CategoryFavorites { get; set; }

        /// <summary>
        /// Gets or sets the cookie consents in the database.
        /// </summary>`
        public DbSet<CookieConsent>? CookieConsents { get; set; }

        /// <summary>
        /// Gets or sets the cookie policies in the database.
        /// </summary>`
        public DbSet<CookiePolicy>? CookiePolicies { get; set; }

        /// <summary>
        /// Gets or sets the cookie policie translations in the database.
        /// </summary>`
        public DbSet<CookiePolicyTranslation>? CookiePolicyTranslations { get; set; }

        /// <summary>
        /// Represents the collection of conversations.
        /// </summary>
        public DbSet<Conversation>? Conversations { get; set; }

        /// <summary>
        /// Gets or sets the coupons in the database.
        /// </summary>
        public DbSet<Coupon>? Coupons { get; set; }

        /// <summary>
        /// Gets or sets the customers in the database.
        /// </summary>
        public DbSet<Customer>? Customers { get; set; }

        /// <summary>
        /// Gets or sets the customers related with coupons in the database.
        /// </summary>
        public DbSet<CustomerCoupon>? CustomersCoupons { get; set; }

        /// <summary>
        /// Gets or sets the customer payment methods in the database.
        /// </summary>
        public DbSet<CustomerPaymentMethod>? CustomerPaymentMethods { get; set; }

        /// <summary>
        /// Gets or sets the customer segmentations with coupons in the database.
        /// </summary>
        public DbSet<CustomerSegmentation>? CustomerSegmentations { get; set; }

        /// <summary>
        /// Gets or sets the customer shipping methods in the database.
        /// </summary>
        public DbSet<CustomerShippingMethod>? CustomerShippingMethods { get; set; }

        /// <summary>
        /// Gets or sets the discounts in the database.
        /// </summary>
        public DbSet<Discount>? Discounts { get; set; }

        /// <summary>
        /// Represents the collection of email campaigns.
        /// </summary>
        public DbSet<EmailCampaign>? EmailCampaigns { get; set; }

        /// <summary>
        /// Represents the collection of email campaign translations.
        /// </summary>
        public DbSet<EmailCampaignTranslation>? EmailCampaignTranslations { get; set; }

        /// <summary>
        /// Gets or sets the employees in the database.
        /// </summary>
        public DbSet<Employee>? Employees { get; set; }

        /// <summary>
        /// Gets or sets the event log in the database.
        /// </summary>
        public DbSet<EventLog>? EventLogs { get; set; }

        /// <summary>
        /// Represents the collection of inventory items stored in the system.
        /// </summary>
        public DbSet<InventoryItem>? InventoryItems { get; set; }

        /// <summary>
        /// Represents the collection of inventory item stored in the zones.
        /// </summary>
        public DbSet<InventoryItemZone>? InventoryItemZones { get; set; }

        /// <summary>
        /// Represents the collection of inventory receipt containing inventory transactions.
        /// </summary>
        public DbSet<InventoryMovement>? InventoryMovements { get; set; }

        /// <summary>
        /// Represents the collection of inventory receipt containing inventory transactions.
        /// </summary>
        public DbSet<InventoryReceipt>? InventoryReceipts { get; set; }

        /// <summary>
        /// Represents the collection of inventory transactions, tracking movements and adjustments of items.
        /// </summary>
        public DbSet<InventoryTransaction>? InventoryTransactions { get; set; }

        /// <summary>
        /// Represents the collection of labels for the products.
        /// </summary>
        public DbSet<Label>? Labels { get; set; }

        /// <summary>
        /// Represents the collection of messages.
        /// </summary>
        public DbSet<Message>? Messages { get; set; }

        /// <summary>
        /// Gets or sets the marketplace info in the database.
        /// </summary>
        public DbSet<MarketplaceInfo>? MarketplaceInfos { get; set; }

        /// <summary>
        /// Gets or sets the marketplace info translations in the database.
        /// </summary>
        public DbSet<MarketplaceInfoTranslation>? MarketplaceInfoTranslations { get; set; }

        /// <summary>
        /// Gets or sets the marketplace policies in the database.
        /// </summary>
        public DbSet<MarketplacePolicy>? MarketplacePolicies { get; set; }

        /// <summary>
        /// Gets or sets the marketplace policy translations in the database.
        /// </summary>
        public DbSet<MarketplacePolicyTranslation>? MarketplacePolicyTranslations { get; set; }

        /// <summary>
        /// Gets or sets the marketplace shippings in the database.
        /// </summary>
        public DbSet<MarketplaceShipping>? MarketplaceShippings { get; set; }

        /// <summary>
        /// Gets or sets the marketplace shipping translations in the database.
        /// </summary>
        public DbSet<MarketplaceShippingTranslation>? MarketplaceShippingTranslations { get; set; }

        /// <summary>
        /// Gets or sets the marketplace returns in the database.
        /// </summary>
        public DbSet<MarketplaceReturns>? MarketplaceReturns { get; set; }

        /// <summary>
        /// Gets or sets the marketplace return translations in the database.
        /// </summary>
        public DbSet<MarketplaceReturnsTranslation>? MarketplaceReturnsTranslations { get; set; }

        /// <summary>
        /// Gets or sets the marketplace partnerships in the database.
        /// </summary>
        public DbSet<MarketplacePartnership>? MarketplacePartnerships { get; set; }

        /// <summary>
        /// Gets or sets the marketplace partnership translations in the database.
        /// </summary>
        public DbSet<MarketplacePartnershipTranslation>? MarketplacePartnershipTranslations { get; set; }

        /// <summary>
        /// Gets or sets the marketplace guarantees in the database.
        /// </summary>
        public DbSet<MarketplaceGuarantee>? MarketplaceGuarantees { get; set; }

        /// <summary>
        /// Gets or sets the marketplace guarantee translations in the database.
        /// </summary>
        public DbSet<MarketplaceGuaranteeTranslation>? MarketplaceGuaranteeTranslations { get; set; }

        /// <summary>
        /// Gets or sets the newsletter subscriptions in the database.
        /// </summary>
        public DbSet<NewsletterSubscription>? NewsletterSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets the notifications in the database.
        /// </summary>
        public DbSet<Notification>? Notifications { get; set; }

        /// <summary>
        /// Gets or sets the notification translations in the database.
        /// </summary>
        public DbSet<NotificationTranslation>? NotificationTranslations { get; set; }

        /// <summary>
        /// Gets or sets the orders in the database.
        /// </summary>
        public DbSet<Order>? Orders { get; set; }

        /// <summary>
        /// Gets or sets the order items in the database.
        /// </summary>
        public DbSet<OrderItem>? OrderItems { get; set; }

        /// <summary>
        /// Gets or sets the partnership agreements in the database.
        /// </summary>
        public DbSet<PartnershipAgreement>? PartnershipAgreements { get; set; }

        /// <summary>
        /// Gets or sets the partnership agreement consents in the database.
        /// </summary>
        public DbSet<PartnershipAgreementConsent>? PartnershipAgreementConsents { get; set; }

        /// <summary>
        /// Gets or sets the partnership agreement translations in the database.
        /// </summary>
        public DbSet<PartnershipAgreementTranslation>? PartnershipAgreementTranslations { get; set; }

        /// <summary>
        /// Gets or sets the payments in the database.
        /// </summary>
        public DbSet<Payment>? Payments { get; set; }

        /// <summary>
        /// Gets or sets the payment methods in the database.
        /// </summary>
        public DbSet<PaymentMethod>? PaymentMethods { get; set; }

        /// <summary>
        /// Gets or sets the payout schedules in the database.
        /// </summary>
        public DbSet<PayoutSchedule>? PayoutSchedules { get; set; }

        /// <summary>
        /// Gets or sets the price histories in the database.
        /// </summary>
        public DbSet<PriceHistory>? PriceHistories { get; set; }

        /// <summary>
        /// Gets or sets the products in the database.
        /// </summary>
        public DbSet<Product>? Products { get; set; }

        /// <summary>
        /// Represents the collection of product bundles in the database.
        /// </summary>
        public DbSet<ProductBundle>? ProductBundles { get; set; }

        /// <summary>
        /// Represents the collection of items that belong to product bundles in the database.
        /// </summary>
        public DbSet<ProductBundleItem>? ProductBundleItems { get; set; }

        /// <summary>
        /// Represents the collection of product bundle translations in the database.
        /// </summary>
        public DbSet<ProductBundleTranslation>? ProductBundleTranslations { get; set; }

        /// <summary>
        /// Gets or sets the product categories in the database.
        /// </summary>
        public DbSet<ProductCategory>? ProductCategories { get; set; }

        /// <summary>
        /// Gets or sets the product categorie translations in the database.
        /// </summary>
        public DbSet<ProductCategoryTranslation>? ProductCategoryTranslations { get; set; }

        /// <summary>
        /// Gets or sets the product discounts in the database.
        /// </summary>
        public DbSet<ProductDiscount>? ProductsDiscounts { get; set; }

        /// <summary>
        /// Gets or sets the favorite products in the database.
        /// </summary>
        public DbSet<ProductFavorite>? ProductFavorites { get; set; }        

        /// <summary>
        /// Gets or sets the product images in the database.
        /// </summary>
        public DbSet<ProductImage>? ProductImages { get; set; }

        /// <summary>
        /// Gets or sets the product reviews in the database.
        /// </summary>
        public DbSet<ProductReview>? ProductReviews { get; set; }

        /// <summary>
        /// Gets or sets the products and tags in the database.
        /// </summary>
        public DbSet<ProductTag>? ProductsTags { get; set; }

        /// <summary>
        /// Gets or sets the product translations in the database.
        /// </summary>
        public DbSet<ProductTranslation>? ProductTranslations { get; set; }

        /// <summary>
        /// Gets or sets the product variants in the database.
        /// </summary>
        public DbSet<ProductVariant>? ProductVariants { get; set; }

        /// <summary>
        /// Gets or sets the product variant translations in the database.
        /// </summary>
        public DbSet<ProductVariantTranslation>? ProductVariantTranslations { get; set; }

        /// <summary>
        /// Gets or sets the product variant attributes in the database.
        /// </summary>
        public DbSet<ProductVariantAttribute>? ProductVariantAttributes { get; set; }

        /// <summary>
        /// Gets or sets the product variant attribute translations in the database.
        /// </summary>
        public DbSet<ProductVariantAttributeTranslation>? ProductVariantAttributeTranslations { get; set; }

        /// <summary>
        /// Gets or sets the product variant discounts in the database.
        /// </summary>
        public DbSet<ProductVariantDiscount>? ProductVariantsDiscounts { get; set; }

        /// <summary>
        /// Gets or sets the refresh token in the database.
        /// </summary>
        public DbSet<RefreshToken>? RefreshTokens { get; set; }

        /// <summary>
        /// Gets or sets the refund in the database.
        /// </summary>
        public DbSet<Refund>? Refunds { get; set; }

        /// <summary>
        /// Gets or sets the return notes in the database.
        /// </summary>
        public DbSet<ReturnNote>? ReturnNotes { get; set; }

        /// <summary>
        /// Gets or sets the return requests in the database.
        /// </summary>
        public DbSet<ReturnRequest>? ReturnRequests { get; set; }

        /// <summary>
        /// Gets or sets the return request items in the database.
        /// </summary>
        public DbSet<ReturnRequestItem>? ReturnRequestItems { get; set; }

        /// <summary>
        /// Gets or sets the review photos in the database.
        /// </summary>
        public DbSet<ReviewPhoto>? ReviewPhotos { get; set; }

        /// <summary>
        /// Gets or sets the sales analytics carts in the database.
        /// </summary>
        public DbSet<SalesAnalytics>? SalesAnalytics { get; set; }

        /// <summary>
        /// Gets or sets the external sellers analytics in the database.
        /// </summary>
        public DbSet<SellerAnalytics>? SellerAnalytics { get; set; }

        /// <summary>
        /// Gets or sets the seller in the database.
        /// </summary>
        public DbSet<Seller>? Sellers { get; set; }

        /// <summary>
        /// Gets or sets the seller account balances in the database.
        /// </summary>
        public DbSet<SellerAccountBalance>? SellerAccountBalances { get; set; }

        /// <summary>
        /// Gets or sets the seller bank accounts in the database.
        /// </summary>
        public DbSet<SellerBankAccount>? SellerBankAccounts { get; set; }

        /// <summary>
        /// Gets or sets the seller deposits in the database.
        /// </summary>
        public DbSet<SellerDeposit>? SellerDeposits { get; set; }

        /// <summary>
        /// Gets or sets the sellers discounts in the database.
        /// </summary>
        public DbSet<SellerDiscount>? SellersDiscounts { get; set; }

        /// <summary>
        /// Gets or sets the favorite sellers in the database.
        /// </summary>
        public DbSet<SellerFavorite>? SellerFavorites { get; set; }

        /// <summary>
        /// Gets or sets the seller logos in the database.
        /// </summary>
        public DbSet<SellerLogo>? SellerLogo { get; set; }

        /// <summary>
        /// Gets or sets the seller info translation in the database.
        /// </summary>
        public DbSet<SellerTranslation>? SellerTranslations { get; set; }

        /// <summary>
        /// Gets or sets the shopping carts in the database.
        /// </summary>
        public DbSet<Settings>? Settings { get; set; }

        /// <summary>
        /// Gets or sets the deliveries in the database.
        /// </summary>
        public DbSet<Shipment>? Shipments { get; set; }

        /// <summary>
        /// Gets or sets the methods of the delivery in the database.
        /// </summary>
        public DbSet<ShippingMethod>? ShippingMethods { get; set; }

        /// <summary>
        /// Gets or sets the translations of the shiping methods in the database.
        /// </summary>
        public DbSet<ShippingMethodTranslation>? ShippingMethodTranslations { get; set; }

        /// <summary>
        /// Gets or sets the options of the delivery in the database.
        /// </summary>
        public DbSet<ShippingOption>? ShippingOptions { get; set; }

        /// <summary>
        /// Gets or sets the shopping carts in the database.
        /// </summary>
        public DbSet<ShoppingCart>? ShoppingCarts { get; set; }

        /// <summary>
        /// Gets or sets the shopping cart items in the database.
        /// </summary>
        public DbSet<ShoppingCartItem>? ShoppingCartItems { get; set; }

        /// <summary>
        /// Gets or sets the social media links in the database.
        /// </summary>
        public DbSet<SocialMediaLink>? SocialMediaLinks { get; set; }

        /// <summary>
        /// Represents the collection of suppliers who provides products to the warehouse.
        /// </summary>
        public DbSet<Supplier>? Suppliers { get; set; }

        /// <summary>
        /// Gets or sets the support ticket in the database.
        /// </summary>
        public DbSet<SupportTicket>? SupportTickets { get; set; }

        /// <summary>
        /// Gets or sets the tags in the database.
        /// </summary>
        public DbSet<Tag>? Tags { get; set; }

        /// <summary>
        /// Gets or sets the taxes in the database.
        /// </summary>
        public DbSet<Tax>? Taxes { get; set; }

        /// <summary>
        /// Gets or sets the ticket histories in the database.
        /// </summary>
        public DbSet<TicketHistory>? TicketHistories { get; set; }

        /// <summary>
        /// Gets or sets the transaction in the database.
        /// </summary>
        public DbSet<Transaction>? Transactions { get; set; }

        /// <summary>
        /// Gets or sets the user activity log in the database.
        /// </summary>
        public DbSet<UserActivityLog>? UserActivityLogs { get; set; }

        /// <summary>
        /// Gets or sets the user addresses in the database.
        /// </summary>
        public DbSet<UserAddress>? UserAddresses { get; set; }

        /// <summary>
        /// Gets or sets the user agreements in the database.
        /// </summary>
        public DbSet<UserAgreement>? UserAgreements { get; set; }

        /// <summary>
        /// Gets or sets the user agreement consents in the database.
        /// </summary>
        public DbSet<UserAgreementConsent>? UserAgreementConsents { get; set; }

        /// <summary>
        /// Gets or sets the user agreement translaions in the database.
        /// </summary>
        public DbSet<UserAgreementTranslation>? UserAgreementTranslations { get; set; }

        /// <summary>
        /// Represents the collection of warehouses in the system.
        /// </summary>
        public DbSet<Warehouse>? Warehouses { get; set; }

        /// <summary>
        /// Represents the collection of zones within a warehouse for better item organization.
        /// </summary>
        public DbSet<WarehouseZone>? WarehouseZones { get; set; }

        /// <summary>
        /// Represents the collection of specific positions or locations within warehouse zones.
        /// </summary>
        public DbSet<ZonePosition>? ZonePositions { get; set; }


        /// <summary>
        /// Configures the model that was discovered by convention from the entity types exposed in <see cref="DbSet{TEntity}"/> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryDiscount>()
                .HasKey(cd => new { cd.CategoryId, cd.DiscountId });

            modelBuilder.Entity<SellerDiscount>()
                .HasKey(cd => new { cd.SellerId, cd.DiscountId });

            modelBuilder.Entity<CustomerCoupon>()
                .HasKey(cc => new { cc.CustomerId, cc.CouponId });

            modelBuilder.Entity<ProductDiscount>()
                .HasKey(pd => new { pd.ProductId, pd.DiscountId });

            modelBuilder.Entity<ProductVariantDiscount>()
                .HasKey(pvd => new { pvd.ProductVariantId, pvd.DiscountId });

            modelBuilder.Entity<CustomerPaymentMethod>()
                .HasKey(cpm => new { cpm.CustomerId, cpm.PaymentMethodId });

            modelBuilder.Entity<ProductTag>()
                .HasKey(pt => new { pt.ProductId, pt.TagId });

            modelBuilder.Entity<CustomerShippingMethod>()
                .HasKey(csm => new { csm.CustomerId, csm.ShippingMethodId });

            modelBuilder.Entity<UserAddress>()
                .HasKey(ua => new { ua.UserId, ua.AddressId });

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.UserId)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.UserId)
                .IsUnique();

            modelBuilder.Entity<Seller>()
                .HasIndex(e => e.UserId)
                .IsUnique();

            modelBuilder.Entity<Label>()
                .HasIndex(l => l.Code)
                .IsUnique();

            modelBuilder.Entity<Seller>()
                .Property(s => s.Rating)
                .HasPrecision(3, 2);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.User)
                .WithOne(u => u.Customer)
                .HasForeignKey<Customer>(c => c.UserId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.User)
                .WithOne(u => u.Employee)
                .HasForeignKey<Employee>(e => e.UserId);

            modelBuilder.Entity<Seller>()
                .HasOne(s => s.User)
                .WithOne(u => u.Seller)
                .HasForeignKey<Seller>(e => e.UserId);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
             .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
