using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ErgodicMage.Result;

public static partial class GuardClause
{
    public static Result Minimum<T>(T input, T minimum, 
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
    {
        if (input.CompareTo(minimum) >= 0) return Result.Ok();
        return Result.Error(message ?? $"Minimum Error: {parameterName} ({input}) is less than {nameof(minimum)} ({minimum})");
    }

    public static Result Minimum<T>(this Result result, T input, T minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
        => result.Success ? Minimum(input, minimum, parameterName, message) : result;

    public static Result Maximum<T>(T input, T maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
    {
        if (input.CompareTo(maximum) <= 0) return Result.Ok();
        return Result.Error(message ?? $"Maximum Error: {parameterName} ({input}) is greater than {nameof(maximum)} ({maximum})");
    }

    public static Result Maximum<T>(this Result result, T input, T maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null) where T : struct, IComparable
        => result.Success ? Maximum(input, maximum, parameterName, message) : result;

    public static Result Minimum(short input, short minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<short>(input, minimum, parameterName, message);

    public static Result Minimum(this Result result, short input, short minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<short>(result, input, minimum, parameterName, message);

    public static Result Maximum(short input, short maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<short>(input, maximum, parameterName, message);

    public static Result Maximum(this Result result, short input, short maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<short>(result, input, maximum, parameterName, message);

    public static Result Minimum(int input, int minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<int>(input, minimum, parameterName, message);

    public static Result Minimum(this Result result, int input, int minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<int>(result, input, minimum, parameterName, message);

    public static Result Maximum(int input, int maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<int>(input, maximum, parameterName, message);

    public static Result Maximum(this Result result, int input, int maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<int>(result, input, maximum, parameterName, message);

    public static Result Minimum(long input, long minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<long>(input, minimum, parameterName, message);

    public static Result Minimum(this Result result, long input, long minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<long>(result, input, minimum, parameterName, message);

    public static Result Maximum(long input, long maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<long>(input, maximum, parameterName, message);

    public static Result Maximum(this Result result, long input, long maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<long>(result, input, maximum, parameterName, message);

    public static Result Minimum(float input, float minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<float>(input, minimum, parameterName, message);

    public static Result Minimum(this Result result, float input, float minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<float>(result, input, minimum, parameterName, message);

    public static Result Maximum(float input, float maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<float>(input, maximum, parameterName, message);

    public static Result Maximum(this Result result, float input, float maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<float>(result, input, maximum, parameterName, message);

    public static Result Minimum(double input, double minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<double>(input, minimum, parameterName, message);

    public static Result Minimum(this Result result, double input, double minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<double>(result, input, minimum, parameterName, message);

    public static Result Maximum(double input, double maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<double>(input, maximum, parameterName, message);

    public static Result Maximum(this Result result, double input, double maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<double>(result, input, maximum, parameterName, message);

    public static Result Minimum(decimal input, decimal minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<decimal>(input, minimum, parameterName, message);

    public static Result Minimum(this Result result, decimal input, decimal minimum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Minimum<decimal>(result, input, minimum, parameterName, message);

    public static Result Maximum(decimal input, decimal maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<decimal>(input, maximum, parameterName, message);

    public static Result Maximum(this Result result, decimal input, decimal maximum,
        [CallerArgumentExpression(nameof(input))] string? parameterName = null, string? message = null)
        => Maximum<decimal>(result, input, maximum, parameterName, message);
}
