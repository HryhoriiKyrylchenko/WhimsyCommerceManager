namespace Whimsy_WebAPI.Utilities
{
    /// <summary>
    /// Represents an error with a message, an optional code, and optional details.
    /// Implements the <see cref="IError"/> interface.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="Error"/> class.
    /// </remarks>
    /// <param name="message">The message describing the error.</param>
    /// <param name="code">An optional error code.</param>
    /// <param name="details">Optional details providing additional context about the error.</param>
    public class Error(string message, string? code = null, string? details = null) : IError
    {
        /// <summary>
        /// Gets or sets the message describing the error.
        /// </summary>
        public string Message { get; set; } = message;

        /// <summary>
        /// Gets or sets an optional error code associated with the error, if available.
        /// </summary>
        public string? Code { get; set; } = code;

        /// <summary>
        /// Gets or sets optional details providing additional information about the error, if available.
        /// </summary>
        public string? Details { get; set; } = details;
    }
}
