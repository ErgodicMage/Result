using System;
using System.Reflection.Metadata;

namespace ErgodicMage.Result;

public readonly partial record struct Result
{
    public bool Success { get; init;  }
    public string ErrorMessage { get; init;  }
    public Exception? Exception { get; init; }

    public Result(bool success)
    {
        Success = success;
        ErrorMessage = string.Empty;
        Exception = default;
    }

    public Result(bool success, string errorMessage, Exception? ex = default)
    {
        Success = success;
        ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : string.Empty; ;
        Exception = ex;
    }

    public Result(string errorMessage, Exception? ex = default)
    {
        Success = false;
        ErrorMessage = string.IsNullOrEmpty(errorMessage) && ex is not null ? ex.Message : string.Empty;
        Exception = ex;
    }

    public static Result Ok() => new(true);
    public static Result Error(string errorMessage, Exception? ex = default) => new(errorMessage, ex);
    public static Result Error(Exception ex, string? errorMessage = "") => new(errorMessage, ex);
}
