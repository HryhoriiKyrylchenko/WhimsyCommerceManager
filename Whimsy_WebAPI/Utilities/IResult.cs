namespace Whimsy_WebAPI.Utilities
{
    /// <summary>
    /// Represents the result of an operation, including its success status and any associated errors.
    /// </summary>
    public interface IResult
    {
        /// <summary>
        /// Gets a value indicating whether the operation was successful.
        /// </summary>
        bool Succeeded { get; }

        /// <summary>
        /// Gets a list of errors that occurred during the operation, if any.
        /// </summary>
        List<IError> Errors { get; }
    }
}
