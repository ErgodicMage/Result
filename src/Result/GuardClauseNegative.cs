using System.Runtime.CompilerServices;

namespace ErgodicMage.Result;

public static partial class GuardClause
{
    public static Result Negative<T>(T input, [CallerArgumentExpression("input")] string? parameterName = null,
    string? message = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) >= 0) return Result.Ok();

        string msg = message ?? "Value can not be negative";
        Exception ex = new ArgumentException(msg, parameterName);

        return Result.Error(msg, ex);
    }

    public static Result Negative<T>(this Result result, T input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null) where T : struct, IComparable
        => result.Success ? Negative(input, parameterName, message) : result;

    public static Result NegativeOrZero<T>(T input, [CallerArgumentExpression("input")] string? parameterName = null,
    string? message = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) > 0) return Result.Ok();

        string msg = message ?? "Value is not positive";
        Exception ex = new ArgumentException(msg, parameterName);

        return Result.Error(msg, ex);
    }

    public static Result NegativeOrZero<T>(this Result result, T input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null) where T : struct, IComparable
        => result.Success ? NegativeOrZero(input, parameterName, message) : result;

    public static Result Negative(short input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<short>(input, parameterName, message);

    public static Result Negative(this Result result, short input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<short>(result, input, parameterName, message);

    public static Result Negative(int input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<int>(input, parameterName, message);

    public static Result Negative(this Result result, int input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<int>(result, input, parameterName, message);

    public static Result Negative(long input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<long>(input, parameterName, message);

    public static Result Negative(this Result result, long input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<long>(result, input, parameterName, message);

    public static Result Negative(float input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<float>(input, parameterName, message);

    public static Result Negative(this Result result, float input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<float>(result, input, parameterName, message);

    public static Result Negative(double input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<double>(input, parameterName, message);

    public static Result Negative(this Result result, double input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<double>(result, input, parameterName, message);

    public static Result Negative(decimal input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<decimal>(input, parameterName, message);

    public static Result Negative(this Result result, decimal input, [CallerArgumentExpression("input")] string? parameterName = null,
        string? message = null)
        => Negative<decimal>(result, input, parameterName, message);

}
