namespace ErgodicMage.Result;

public readonly partial record struct Result<T>
    (bool Success, string ErrorMessage, Exception? Exception, T Value)
{
    public static implicit operator T(Result<T> result) => result.Value;
    public static implicit operator Result<T>(Result result) => new()
        { 
            Success = result.Success, 
            ErrorMessage = string.IsNullOrEmpty(result.ErrorMessage) && result.Exception is not null ? result.Exception.Message : result.ErrorMessage, 
            Exception = result.Exception 
        };
    public static implicit operator Result<T>(T value) => new() { Success = value is not null, Value = value };
    public static implicit operator Result(Result<T> result) => new()
        { 
            Success = result.Success, 
            ErrorMessage = result.ErrorMessage, 
            Exception = result.Exception 
        };

    public static Result<T> Ok(T value) => new() { Success = value is not null, Value = value };
    public static Result<T> Error(string errorMessage, Exception? ex = default) => new()
        { 
            Success = false,
            ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : errorMessage, 
            Exception = ex 
        };
    public static Result<T> Error(Exception ex, string errorMessage = "") => new()
        { 
            Success = false,
            ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : 
            errorMessage, Exception = ex 
        };
}
