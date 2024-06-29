using System.Runtime.CompilerServices;

namespace ErgodicMage.Result;

//public readonly record struct GuardClause(bool Success, IList<string> Errors);

public static partial class GuardClause
{
    public static Result Null(object? input, [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
    {
        if (input is not null) return Result.Ok();

        return Result.Error(message ?? $"Null Error: {parameterName}");
    }

    public static Result Null(this Result result, object? input, [CallerArgumentExpression(nameof(input))] string? parameterName = null, 
        string? message = null)
        => result.Success ? Null(input, parameterName, message) : result;

    public static Result NullOrEmpty(string? input, [CallerArgumentExpression(nameof(input))] string? parameterName = null, 
        string? message = null)
    {
        if (!string.IsNullOrEmpty(input)) return Result.Ok();

        return Result.Error(message ?? $"NullOrEmpty Error: {parameterName}");
    }

    public static Result NullOrEmpty(this Result result, string? input, [CallerArgumentExpression(nameof(input))] string? parameterName = null,
        string? message = null)
        => result.Success ? NullOrEmpty(input, parameterName, message) : result;

    public static Result NullOrWhiteSpace(string? input, [CallerArgumentExpression(nameof(input))] string? parameterName = null, 
        string? message = null)
    {
        if (!string.IsNullOrWhiteSpace(input)) return Result.Ok();

        return Result.Error(message ?? $"NullOrWhiteSpace Error: {parameterName}");
    }

    public static Result NullOrWhiteSpace(this Result result, string? input, 
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => result.Success ? Null(input, parameterName, message) : result;
}
