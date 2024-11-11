namespace Whimsy_WebAPI.Utilities
{
    /// <summary>
    /// Represents the result of an operation that returns data, including its success status, errors, and the resulting data.
    /// </summary>
    /// <typeparam name="T">The type of data returned by the operation.</typeparam>
    public interface IOperationResult<T> : IResult
    {
        /// <summary>
        /// Gets the data returned by the operation, if the operation was successful.
        /// </summary>
        T? Data { get; }
    }
}
