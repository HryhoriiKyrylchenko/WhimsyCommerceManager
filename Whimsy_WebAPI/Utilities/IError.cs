namespace Whimsy_WebAPI.Utilities
{
    /// <summary>
    /// Represents an error with a message, an optional code, and optional details.
    /// </summary>
    public interface IError
    {
        /// <summary>
        /// Gets the message describing the error.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Gets an optional error code associated with the error, if available.
        /// </summary>
        string? Code { get; }

        /// <summary>
        /// Gets optional details providing additional information about the error, if available.
        /// </summary>
        string? Details { get; }
    }
}
