namespace ErgodicMage.Result;

public readonly partial record struct Result
{
    #region Sync
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
    #endregion

    #region Async
    public async static Task<Result> TryAsync(Func<CancellationToken, Task> func, CancellationToken token = default )
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            await func(token);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public async static Task<Result> TryAsync<P>(Func<P, CancellationToken, Task> func, P param, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            await func(param, token);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public async static Task<Result> TryAsync<P1, P2>(Func<P1, P2, CancellationToken, Task> func, 
        P1 param1, P2 param2, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            await func(param1, param2, token);
            return Result.Ok();
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public async static Task<Result> TryAsync(Func<CancellationToken, Task<Result>> func, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(token);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public async static Task<Result> TryAsync<P>(Func<P, CancellationToken, Task<bool>> func, 
        P param, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            bool retResult = await func(param, token);
            return retResult ? Result.Ok() : Result.Error(string.Empty);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public async static Task<Result> TryAsync<P>(Func<P, CancellationToken, Task<Result>> func, 
        P param, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(param, token);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public async static Task<Result> TryAsync<P1, P2>(Func<P1, P2, CancellationToken, Task<bool>> func, 
        P1 param1, P2 param2, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            bool retResult = await func(param1, param2, token);
            return retResult ? Result.Ok() : Result.Error(string.Empty);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }

    public async static Task<Result> TryAsync<P1, P2>(Func<P1, P2, CancellationToken, Task<Result>> func, 
        P1 param1, P2 param2, CancellationToken token = default)
    {
        Result result = GuardClause.Null(func);
        if (!result.Success) return result;

        try
        {
            return await func(param1, param2, token);
        }
        catch (Exception ex)
        {
            return Result.Error(ex);
        }
    }
    #endregion
}
