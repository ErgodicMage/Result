using System.Runtime.CompilerServices;

namespace ErgodicMage.Result;

public static partial class GuardClause
{
    public static Result OutOfRange<T>(T input, T rangeFrom, T rangeTo, 
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
    {
        if (rangeFrom.CompareTo(rangeTo) > 0)
            return Result.Error(message ?? $"OutOfRange Error: {nameof(rangeFrom)} ({rangeFrom}) should be less than {nameof(rangeTo)} ({rangeTo})");

        if (input.CompareTo(rangeFrom) < 0 || input.CompareTo(rangeTo) > 0)
            return Result.Error(message ?? $"OutOfRange Error: {parameterName} ({input}) is out of range of ({rangeFrom}) ({rangeTo})");

        return Result.Ok();
    }

    public static Result OutOfRange<T>(this Result result, T input, T rangeFrom, T rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
        => result.Success ? OutOfRange(input, rangeFrom, rangeTo, parameterName, message) : result;

    public static Result OutOfRange(short input, short rangeFrom, short rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => OutOfRange<short>(input, rangeFrom, rangeTo, parameterName, message);

    public static Result OutOfRange(this Result result, short input, short rangeFrom, short rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => result.Success ? OutOfRange<short>(result, input, rangeFrom, rangeTo, parameterName, message) : result;

    public static Result OutOfRange(int input, int rangeFrom, int rangeTo,
    [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
    => OutOfRange<int>(input, rangeFrom, rangeTo, parameterName, message);

    public static Result OutOfRange(this Result result, int input, int rangeFrom, int rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => result.Success ? OutOfRange<int>(result, input, rangeFrom, rangeTo, parameterName, message) : result;

    public static Result OutOfRange(long input, long rangeFrom, long rangeTo,
    [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
    => OutOfRange<long>(input, rangeFrom, rangeTo, parameterName, message);

    public static Result OutOfRange(this Result result, long input, long rangeFrom, long rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => result.Success ? OutOfRange<long>(result, input, rangeFrom, rangeTo, parameterName, message) : result;

    public static Result OutOfRange(float input, float rangeFrom, float rangeTo,
    [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
    => OutOfRange<float>(input, rangeFrom, rangeTo, parameterName, message);

    public static Result OutOfRange(this Result result, float input, float rangeFrom, float rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => result.Success ? OutOfRange<float>(result, input, rangeFrom, rangeTo, parameterName, message) : result;

    public static Result OutOfRange(double input, double rangeFrom, double rangeTo,
    [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
    => OutOfRange<double>(input, rangeFrom, rangeTo, parameterName, message);

    public static Result OutOfRange(this Result result, double input,   double rangeFrom, double rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => result.Success ? OutOfRange<double>(result, input, rangeFrom, rangeTo, parameterName, message) : result;

    public static Result OutOfRange(decimal input, decimal rangeFrom, decimal rangeTo,
    [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
    => OutOfRange<decimal>(input, rangeFrom, rangeTo, parameterName, message);

    public static Result OutOfRange(this Result result, decimal input, decimal rangeFrom, decimal rangeTo,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => result.Success ? OutOfRange<decimal>(result, input, rangeFrom, rangeTo, parameterName, message) : result;
}
