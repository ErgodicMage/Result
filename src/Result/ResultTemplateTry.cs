namespace ErgodicMage.Result;

public readonly partial record struct Result<T>
{
    #region Sync
    public static Result<T> Try(Func<Result<T>> func)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func();
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public static Result<T> Try(Func<T> func)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func();
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public static Result<T> Try<P>(Func<P, Result<T>> func, P param)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func(param);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public static Result<T> Try<P>(Func<P, T> func, P param)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func(param);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public static Result<T> Try<P1, P2>(Func<P1, P2, Result<T>> func, P1 param1, P2 param2)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func(param1, param2);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public static Result<T> Try<P1, P2>(Func<P1, P2, T> func, P1 param1, P2 param2)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return func(param1, param2);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }
    #endregion

    #region Async
    public async static Task<Result<T>> TryAsync(Func<CancellationToken, Task<Result<T>>> func, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(token);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public async static Task<Result<T>> TryAsync(Func<CancellationToken, Task<T>> func, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(token);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public async static Task<Result<T>> TryAsync<P>(Func<P, CancellationToken, Task<Result<T>>> func, P param, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(param, token);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public async static Task<Result<T>> TryAsync<P>(Func<P, CancellationToken, Task<T>> func, P param, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(param, token);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public async static Task<Result<T>> TryAsync<P1, P2>(Func<P1, P2, CancellationToken, Task<Result<T>>> func, P1 param1, P2 param2, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(param1, param2, token);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }

    public async static Task<Result<T>> TryAsync<P1, P2>(Func<P1, P2, CancellationToken, Task<T>> func, P1 param1, P2 param2, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(param1, param2, token);
        }
        catch (Exception ex)
        {
            return Result<T>.Error(ex);
        }
    }
    #endregion
}
