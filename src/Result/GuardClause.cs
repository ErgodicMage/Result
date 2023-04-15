using System.Runtime.CompilerServices;

namespace ErgodicMage.Result;

//public readonly record struct GuardClause(bool Success, IList<string> Errors);

public static partial class GuardClause
{
    public static Result Null(object? input, [CallerArgumentExpression("input")] string? parameterName = null, string? message = null)
    {
        if (input is not null) return Result.Ok();

        Exception ex = new ArgumentNullException(parameterName, message);
        string msg = message ?? ex.Message;

        return Result.Error(msg, ex);
    }

    public static Result Null(this Result result, object? input, [CallerArgumentExpression("input")] string? parameterName = null, 
        string? message = null)
        => result.Success ? Null(input, parameterName, message) : result;

    public static Result NullOrEmpty(string? input, [CallerArgumentExpression("input")] string? parameterName = null, 
        string? message = null)
    {
        if (!string.IsNullOrEmpty(input)) return Result.Ok();

        Exception ex = new ArgumentNullException(parameterName, message);
        string msg = message ?? ex.Message;

        return Result.Error(msg, ex);
    }

    public static Result NullOrEmpty(this Result result, string? input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => result.Success ? NullOrEmpty(input, parameterName, message) : result;

    public static Result NullOrWhiteSpace(string? input, [CallerArgumentExpression("input")] string? parameterName = null, 
        string? message = null)
    {
        if (!string.IsNullOrWhiteSpace(input)) return Result.Ok();

        Exception ex = new ArgumentNullException(parameterName, message);
        string msg = message ?? ex.Message;

        return Result.Error(msg, ex);
    }

    public static Result NullOrWhiteSpace(this Result result, string? input, 
        [CallerArgumentExpression("input")] string? parameterName = null, string? message = null)
        => result.Success ? Null(input, parameterName, message) : result;
}
