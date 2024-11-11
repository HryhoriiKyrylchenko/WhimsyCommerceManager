namespace Whimsy_WebAPI.Utilities
{
    /// <summary>
    /// Represents the result of an operation that returns data, including success status, errors, and the resulting data.
    /// Implements the <see cref="IOperationResult{T}"/> interface.
    /// </summary>
    /// <typeparam name="T">The type of data returned by the operation.</typeparam>
    public class OperationResult<T> : IOperationResult<T>
    {
        /// <summary>
        /// Gets a value indicating whether the operation was successful.
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// Gets or sets the data returned by the operation, if successful.
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Gets the list of errors encountered during the operation.
        /// </summary>
        public List<IError> Errors { get; set; } = [];

        /// <summary>
        /// Gets the value of the data if the operation was successful, otherwise throws an <see cref="InvalidOperationException"/>.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the operation failed.</exception>
        public T Value
        {
            get
            {
                if (!Succeeded)
                {
                    throw new InvalidOperationException("Cannot access Value of a failed operation.");
                }

                return Data!;
            }
        }

        /// <summary>
        /// Creates a successful result with the provided data.
        /// </summary>
        /// <param name="data">The data returned by the operation.</param>
        /// <returns>An <see cref="OperationResult{T}"/> with success status.</returns>
        public static OperationResult<T> SuccessResult(T data)
        {
            return new OperationResult<T> { Succeeded = true, Data = data };
        }

        /// <summary>
        /// Creates a failed result with the provided list of errors.
        /// </summary>
        /// <param name="errors">The list of errors encountered during the operation.</param>
        /// <returns>An <see cref="OperationResult{T}"/> with failure status.</returns>
        public static OperationResult<T> FailureResult(List<IError> errors)
        {
            return new OperationResult<T> { Succeeded = false, Errors = errors };
        }

        /// <summary>
        /// Gets the value of the data if the operation was successful, otherwise returns the default value for the type.
        /// </summary>
        /// <returns>The data if the operation was successful; otherwise, the default value for the type.</returns>
        public T? GetValueOrDefault()
        {
            return Succeeded ? Data : default;
        }

        /// <summary>
        /// Adds an error to the list of errors encountered during the operation.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="code">The optional error code.</param>
        /// <param name="details">The optional error details.</param>
        public void AddError(string message, string? code = null, string? details = null)
        {
            Errors.Add(new Error(message, code, details));
        }

        /// <summary>
        /// Adds a collection of errors to the list of errors encountered during the operation.
        /// </summary>
        /// <param name="errors">The collection of errors to add.</param>
        public void AddErrors(IEnumerable<Error> errors)
        {
            Errors.AddRange(errors);
        }

        /// <summary>
        /// Maps the data from the current operation result to a new type, returning a new <see cref="OperationResult{TResult}"/>.
        /// </summary>
        /// <typeparam name="TResult">The type to which the data should be mapped.</typeparam>
        /// <param name="mapFunc">The function to map the data to the new type.</param>
        /// <returns>A new <see cref="OperationResult{TResult}"/> with the mapped data or failure if the current operation failed.</returns>
        public OperationResult<TResult> Map<TResult>(Func<T, TResult> mapFunc)
        {
            if (!Succeeded) return OperationResult<TResult>.FailureResult(Errors);

            var mappedData = mapFunc(Data!);
            return OperationResult<TResult>.SuccessResult(mappedData);
        }

        /// <summary>
        /// Binds the data from the current operation result to a new operation result of a different type.
        /// </summary>
        /// <typeparam name="TResult">The type of the new operation result.</typeparam>
        /// <param name="bindFunc">The function to bind the data to a new <see cref="OperationResult{TResult}"/>.</param>
        /// <returns>A new <see cref="OperationResult{TResult}"/> based on the binding function or failure if the current operation failed.</returns>
        public OperationResult<TResult> Bind<TResult>(Func<T, OperationResult<TResult>> bindFunc)
        {
            if (!Succeeded) return OperationResult<TResult>.FailureResult(Errors);

            return bindFunc(Data!);
        }
    }
}
