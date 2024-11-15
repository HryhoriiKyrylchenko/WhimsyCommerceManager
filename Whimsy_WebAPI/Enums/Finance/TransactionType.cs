namespace Whimsy_WebAPI.Enums.Finance
{
    /// <summary>
    /// Represents the different types of financial transactions within the system.
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Indicates a payment transaction where money is transferred for a purchase or service.
        /// </summary>
        Payment,

        /// <summary>
        /// Indicates a refund transaction where money is returned to a customer for a previously completed payment.
        /// </summary>
        Refund,

        /// <summary>
        /// Indicates a deposit transaction where money is transferred from a seller to marketplace.
        /// </summary>
        SellerDeposit,

        /// <summary>
        /// Indicates a deposit transaction where money is transferred to a seller.
        /// </summary>
        SellerPayout
    }
}
