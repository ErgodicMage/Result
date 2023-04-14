using Microsoft.VisualBasic;

namespace ErgodicMage.Result;

public readonly partial record struct Result<T>
{
    public bool Success { get; init; }
    public string ErrorMessage { get; init; }
    public Exception? Exception { get; init; }
    public T Value { get; init; }

    public Result(T value)
    {
        Success = value is not null;
        Value = value;
        ErrorMessage = string.Empty;
        Exception = default;
    }

    public Result(bool success, string errorMessage, Exception? ex = default)
    { 
        Success = success;
        Value = default!;
        ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : errorMessage; 
        Exception = ex;
    }

    public Result(string errorMessage, Exception? ex = default)
    {
        Success = false;
        Value = default!;
        ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : errorMessage;
        Exception = ex;
    }

    public static implicit operator T(Result<T> result) => result.Value;
    public static implicit operator Result<T>(Result result) => new Result<T>(result.Success, result.ErrorMessage, result.Exception);
    public static implicit operator Result<T>(T value) => new Result<T>(value);
    public static implicit operator Result(Result<T> result) => new Result(result.Success, result.ErrorMessage, result.Exception);

    public static Result<T> Ok(T t) => new(t);
    public static Result<T> Error(string errorMessage, Exception? ex = default) => new(errorMessage, ex);
    public static Result<T> Error(Exception ex, string errorMessage = "") => new(errorMessage, ex);
}
