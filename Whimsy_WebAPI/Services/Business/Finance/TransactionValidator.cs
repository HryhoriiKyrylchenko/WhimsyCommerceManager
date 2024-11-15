using Whimsy_WebAPI.Enums.Finance;
using Whimsy_WebAPI.Models.DataModels.Finance;

namespace Whimsy_WebAPI.Services.Business.Finance
{
    /// <summary>
    /// Validates the integrity of a <see cref="Transaction"/> based on its type and associated details.
    /// Ensures that the correct transaction details (Payment, Refund, SellerDeposit, or PayoutSchedule) are provided,
    /// and that no other conflicting details are included for each transaction type.
    /// </summary>
    public class TransactionValidator : ITransactionValidator
    {
        /// <summary>
        /// Validates a given <see cref="Transaction"/> object based on its type and associated details.
        /// Throws an exception if the transaction details are not valid for the specified transaction type.
        /// </summary>
        /// <param name="transaction">The <see cref="Transaction"/> to validate.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the transaction contains conflicting or missing details based on its type.
        /// </exception>
        public void ValidateTransaction(Transaction transaction)
        {
            if (transaction.Type == TransactionType.Payment)
            {
                if (transaction.Payment == null)
                    throw new InvalidOperationException("Payment details are required for this transaction type.");
                if (transaction.Refund != null || transaction.SellerDeposit != null || transaction.PayoutSchedule != null)
                    throw new InvalidOperationException("Only Payment details should be provided for a payment transaction.");
            }
            else if (transaction.Type == TransactionType.Refund)
            {
                if (transaction.Refund == null)
                    throw new InvalidOperationException("Refund details are required for this transaction type.");
                if (transaction.Payment != null || transaction.SellerDeposit != null || transaction.PayoutSchedule != null)
                    throw new InvalidOperationException("Only Refund details should be provided for a refund transaction.");
            }
            else if (transaction.Type == TransactionType.SellerDeposit)
            {
                if (transaction.SellerDeposit == null)
                    throw new InvalidOperationException("SellerDeposit details are required for this transaction type.");
                if (transaction.Payment != null || transaction.Refund != null || transaction.PayoutSchedule != null)
                    throw new InvalidOperationException("Only SellerDeposit details should be provided for a seller deposit transaction.");
            }
            else if (transaction.Type == TransactionType.SellerPayout)
            {
                if (transaction.PayoutSchedule == null)
                    throw new InvalidOperationException("PayoutSchedule details are required for this transaction type.");
                if (transaction.Payment != null || transaction.Refund != null || transaction.SellerDeposit != null)
                    throw new InvalidOperationException("Only PayoutSchedule details should be provided for a seller payout transaction.");
            }
        }
    }
}
