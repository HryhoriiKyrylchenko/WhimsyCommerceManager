namespace Whimsy_WebAPI.Enums.Finance
{
    /// <summary>
    /// Enum representing the status of a deposit transaction.
    /// </summary>
    public enum DepositStatus
    {
        /// <summary>
        /// The deposit is pending and has not yet been processed.
        /// </summary>
        Pending,

        /// <summary>
        /// The deposit has been successfully completed.
        /// </summary>
        Completed,

        /// <summary>
        /// The deposit has failed and was not processed successfully.
        /// </summary>
        Failed
    }
}
