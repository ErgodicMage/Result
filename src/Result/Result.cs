using System;
using System.Reflection.Metadata;

namespace ErgodicMage.Result;

public readonly record struct Result
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
        ErrorMessage = errorMessage;
        Exception = ex;
    }

    public Result(string errorMessage, Exception? ex = default)
    {
        Success = false;
        ErrorMessage = errorMessage;
        Exception = ex;
    }

    public static Result Ok() => new(true);
    public static Result Error(string errorMessage, Exception? ex = default) => new(errorMessage, ex);
    public static Result Error(Exception ex, string? errorMessage = "") => new(errorMessage, ex);

    public static Result Try(Action action)
    {
        Result result = GuardClause.Null(action);
        if (!result.Success) return result;

        try
        {
            action();
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public static Result Try<P>(Action<P> action, P param)
    {
        Result result = GuardClause.Null(action);
        if (!result.Success) return result;

        try
        {
            action(param);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public static Result Try<P1, P2>(Action<P1, P2> action, P1 param1, P2 param2)
    {
        Result result = GuardClause.Null(action);
        if (!result.Success) return result;

        try
        {
            action(param1, param2);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public static Result Try(Func<Result> func)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func();
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public static Result Try<P>(Func<P, bool> func, P param)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            bool retResult = func(param);
            return retResult ? Result.Ok() : Result.Error(string.Empty);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public static Result Try<P>(Func<P, Result> func, P param)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func(param);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public static Result Try<P1, P2>(Func<P1, P2, bool> func, P1 param1, P2 param2)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            bool retResult = func(param1, param2);
            return retResult ? Result.Ok() : Result.Error(string.Empty);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public static Result Try<P1, P2>(Func<P1, P2, Result> func, P1 param1, P2 param2)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func(param1, param2);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }
}
