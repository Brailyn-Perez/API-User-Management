namespace Users.ResultPattern
{
    public class  OperationResult<T>
    {
        public OperationResult(T Value, bool IsSuccess, string ErrorMessage)
        {
            _errorMessage = ErrorMessage;
            _isSuccess = IsSuccess;
            _value = Value;
        }

        public T _value { get; }
        public bool _isSuccess { get; }
        public string? _errorMessage { get; }

        public static Task<OperationResult<T>> SuccessAsync(T value)
        => Task.FromResult(new OperationResult<T>(value, true, null));

        public static Task<OperationResult<T>> FailureAsync(string error)
            => Task.FromResult(new OperationResult<T>(default, false, error));

    }
}
