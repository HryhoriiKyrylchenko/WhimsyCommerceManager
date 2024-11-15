namespace Whimsy_WebAPI.Enums.Finance
{
    /// <summary>
    /// Enum representing the status of a payout transaction.
    /// </summary>
    public enum PayoutStatus
    {
        /// <summary>
        /// The payout is pending and has not yet been processed.
        /// </summary>
        Pending,

        /// <summary>
        /// The payout has been successfully completed.
        /// </summary>
        Completed,

        /// <summary>
        /// The payout has failed and was not processed successfully.
        /// </summary>
        Failed
    }
}
