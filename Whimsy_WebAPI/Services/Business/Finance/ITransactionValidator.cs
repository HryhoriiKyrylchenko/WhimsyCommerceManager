using Whimsy_WebAPI.Models.DataModels.Finance;

namespace Whimsy_WebAPI.Services.Business.Finance
{
    /// <summary>
    /// Interface for validating transactions in the system.
    /// Provides a method to validate the integrity and correctness of a <see cref="Transaction"/> object.
    /// </summary>
    public interface ITransactionValidator
    {
        /// <summary>
        /// Validates a given <see cref="Transaction"/> object.
        /// This method checks that the transaction data is valid before it is processed or saved.
        /// </summary>
        /// <param name="transaction">The <see cref="Transaction"/> object to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown if the <paramref name="transaction"/> is null.</exception>
        /// <exception cref="InvalidTransactionException">Thrown if the <paramref name="transaction"/> is not valid.</exception>
        void ValidateTransaction(Transaction transaction);
    }
}
