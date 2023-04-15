namespace ErgodicMage.Result;

public readonly partial record struct Result (bool Success, string ErrorMessage, Exception? Exception)
{
    public static Result Ok() => new() { Success = true };
    public static Result Error(string errorMessage, Exception? ex = default) => new() 
        { 
            Success = false, 
            ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : errorMessage, 
            Exception = ex 
        };
    public static Result Error(Exception ex, string? errorMessage = "") => new() 
        { 
            Success = false, 
            ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : errorMessage, 
            Exception = ex 
        };

    public static implicit operator Result(bool b) => new() { Success = b };
    public static implicit operator bool(Result b) => b.Success;
}
